using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;
using EvilBase;

namespace EvilPlug.Filetypes.Pat
{
    public class PatFile
    {
        protected string m_OriginalContent = "";
        protected PatProcessor m_Processor;
        public List<PatPattern> Patterns = new List<PatPattern>();
        public PatFile(string filename)
        {
            m_OriginalContent = EvilTools.GetTextFileContents(filename);
            m_Processor = new PatProcessor(m_OriginalContent);
            LoadOverlayPattern();
        }

        private void LoadOverlayPattern()
        {
            bool inIt = false;
            foreach (PatProperty prop in Properties)
            {
                if (prop.Key == "OverlayPattern")
                {
                    string[] size = prop.Value.Trim().Explode(" ")[0].Explode(",");
                    inIt = true;
                    continue;
                }

                if (prop.Key == "")
                    continue;

                if (prop.Key == "EndList")
                    break;

                if (inIt)
                    Patterns.Add(new PatPattern(prop.Key));

            }
        }

        public void Save(string filename)
        {
            EvilTools.SaveTextToFile(filename, m_Processor.ToString());
        }

        public List<PatProperty> Properties
        {
            get
            {
                return m_Processor.Properties;
            }
        }
        public bool IsIndoorTileSet
        {
            get
            {
                return ((FindProperty("IsIndoorTileSet") != null) && (!FindProperty("IsIndoorTileSet").Deleted));
            }
            set
            {
                if ((!value) && (FindProperty("IsIndoorTileSet") == null))
                    return;

                if (!value)
                {
                    FindProperty("IsIndoorTileSet").Deleted = true;
                    return;
                }

                if (FindProperty("IsIndoorTileSet") == null)
                    Properties.Add(new PatProperty("IsIndoorTileSet="));
                else
                    FindProperty("IsIndoorTileSet").Deleted = false;
            }
        }

        public bool IsOutdoorTileSet
        {
            get
            {
                return ((FindProperty("IsOutdoorTileSet") != null) && (!FindProperty("IsOutdoorTileSet").Deleted));
            }
            set
            {
                if ((!value) && (FindProperty("IsOutdoorTileSet") == null))
                    return;

                if (!value)
                {
                    FindProperty("IsOutdoorTileSet").Deleted = true;
                    return;
                }

                if (FindProperty("IsOutdoorTileSet") == null)
                    Properties.Add(new PatProperty("IsOutdoorTileSet="));
                else
                    FindProperty("IsOutdoorTileSet").Deleted = false;
            }
        }

        public PatProperty FindProperty(string key)
        {
            foreach (PatProperty prop in Properties)
            {
                if (prop.Key == key)
                    return prop;
            }

            return null;
        }
        public PatProperty FindProperty(string key, int index)
        {
            int cur = 0;

            foreach (PatProperty prop in Properties)
            {
                if (prop.Key == key)
                {
                    if (cur == index)
                        return prop;

                    cur++;
                }
            }

            return null;
        }

    }
}
