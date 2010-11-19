using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilBase;

namespace EvilPlug.Filetypes.Lay
{
    public class LayFile
    {
        protected string m_OriginalContent = "";
        protected LayProcessor m_LayProcessor = null;
        public LayFile(string filename)
        {
            m_OriginalContent = EvilTools.GetTextFileContents(filename);
            m_LayProcessor = new LayProcessor();
            m_LayProcessor.Extract(m_OriginalContent);
        }

        public List<LayProperty> Properties
        {
            get
            {
                return m_LayProcessor.Properties;
            }
        }

        public bool IsSavegame
        {
            get
            {
                if (m_LayProcessor == null)
                    return false;

                return (FindProperty("GeniusEntityID") != null);
            }
        }

        public List<LayEntity> Entities
        {
            get
            {
                return m_LayProcessor.Entities;
            }
        }

        public List<LayProperty> FindProperties(string key)
        {
            List<LayProperty> res = new List<LayProperty>();

            foreach (LayProperty prop in Properties)
            {
                if (prop.Key == key)
                    res.Add(prop);
            }

            return res;
        }

        public LayProperty FindProperty(string key)
        {
            foreach (LayProperty prop in Properties)
            {
                if (prop.Key == key)
                    return prop;
            }

            return null;
        }
        public LayProperty FindProperty(string key, int index)
        {
            int cur = 0;

            foreach (LayProperty prop in Properties)
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


        public List<LayEntity> FindEntities(string descriptionId)
        {
            List<LayEntity> res = new List<LayEntity>();

            foreach (LayEntity ent in Entities)
            {
                if (ent.EntityDescriptionID == descriptionId)
                    res.Add(ent);
            }

            return res;
        }

        public LayEntity FindEntityByGridLocation(int x, int y)
        {
            foreach (LayEntity ent in Entities)
            {
                foreach (System.Drawing.Point point in ent.TilesGrid.Locations)
                {
                    if ((point.X == x) && (point.Y == y))
                        return ent;
                }
            }

            return null;
        }

        public LayEntity FindEntityByPatternLocation(int x, int y)
        {
            foreach (LayEntity ent in Entities)
            {
                if ((ent.Pattern != null) && (ent.Pattern.Location.X == x) && (ent.Pattern.Location.Y == y))
                    return ent;
            }

            return null;
        }
        public LayEntity FindEntity(string descriptionId, int index)
        {
            int cur = 0;

            foreach (LayEntity ent in Entities)
            {
                if (ent.EntityDescriptionID == descriptionId)
                {
                    if (cur == index)
                        return ent;

                    cur++;
                }
            }

            return null;

        }
        public LayEntity FindEntity(string descriptionId)
        {

            foreach (LayEntity ent in Entities)
            {
                if (ent.EntityDescriptionID == descriptionId)
                {
                    return ent;
                }
            }

            return null;
        }

        public LayEntity FindEntityById(string id)
        {

            foreach (LayEntity ent in Entities)
            {
                if (ent.EntityID == id)
                {
                    return ent;
                }
            }

            return null;
        }
        public void Save(string filename)
        {
            EvilTools.SaveTextToFile(filename, m_LayProcessor.ToString());
        }


        public List<LayEntity> GetObjectEntities()
        {
            List<LayEntity> res = new List<LayEntity>();

            foreach (LayEntity ent in Entities)
            {
                if (ent.Pattern != null)
                    res.Add(ent);
            }

            return res;
        }
        public List<LayEntity> GetObjectEntities(int x, int y)
        {
            List<LayEntity> res = new List<LayEntity>();

            foreach (LayEntity ent in Entities)
            {
                if (ent.Pattern == null)
                    continue;

                if (ent.EntityDescriptionID == "13109")
                {
                    LayEntity entx = ent;
                }
                if ((ent.Pattern.Location.X + 1 == x) && (ent.Pattern.Location.Y+ 1 == y))
                    res.Add(ent);
            }

            return res;
        }
    }
}
