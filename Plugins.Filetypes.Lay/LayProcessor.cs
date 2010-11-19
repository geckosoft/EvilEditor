using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;

namespace EvilPlug.Filetypes.Lay
{
    public class LayProperty
    {
        public LayProperty(string line)
        {
            if (!line.Contains("="))
            {
                Key = line;
                Value = null;
            }
            else
            {
                string[] parts = line.Explode("=");
                Value = parts[parts.Length - 1];
                Array.Resize<string>(ref parts, parts.Length - 1);

                Key = string.Join("=", parts);
            }
        }

        public string Key = "";
        public string Value = null;
        public bool Deleted = false;
        public override string ToString()
        {
            if (Value == null)
                return Key;
            else
                return Key + "=" + Value;
        }
        public static implicit operator string(LayProperty prop)
        {
            return prop.Value;
        }
    }
    public class LayProcessor
    {
        List<LayProperty> m_Properties = new List<LayProperty>();

        public List<LayProperty> Properties
        {
            get
            {
                return m_Properties;
            }
        }

        internal void Extract(string layContent)
        {
            layContent = layContent.Replace("\r\n", "\n");
            string[] lines = layContent.Explode("\n", StringSplitOptions.None);

            foreach (string line in lines)
            {
                m_Properties.Add(new LayProperty(line));
            }

           // m_Properties = m_Properties;
            ExtractEntities(m_Properties);
        }

        protected List<LayEntity> m_Entities = new List<LayEntity>();
        public List<LayEntity> Entities
        {
            get
            {
                return m_Entities;
            }
        }
        private void ExtractEntities(List<LayProperty> m_Properties)
        {
            try
            {
                bool inEntities = false;
                int index = -1;
                foreach (LayProperty prop in m_Properties)
                {
                    index++;
                    if (prop.Key == "StartEntityList")
                        inEntities = true;
                    else if (prop.Key == "EndEntityList")
                        break;

                    else if (!inEntities)
                        continue;

                    if (prop.Key == "EntityDescriptionID")
                        m_Entities.Add(new LayEntity(m_Properties, index));


                }
            }
            catch (Exception ex)
            {
                ex = ex;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (LayProperty prop in m_Properties)
            {
                if (prop.Deleted)
                    continue;

                sb.Append(prop.ToString() + "\n");
            }

            return sb.ToString();
        }
        /*internal void Extract(string layContent)
        {
            layContent = layContent.Replace("\r\n", "\n");
            string[] lines = layContent.Explode("\n", StringSplitOptions.RemoveEmptyEntries);
            string currentSection = "";

            if ((m_Sections.Count == 0) || (m_Sections[m_Sections.Count - 1] != currentSection))
            {
                m_Sections.Add(currentSection);
            }

            foreach (string curLine in lines)
            {
                string line = curLine;

                string val = null;
                if (!line.Contains("="))
                {
                    val = null;
                    currentSection = line;
                }
                else
                {
                    string[] parts = line.Explode("=");
                    val = parts[parts.Length - 1];
                    Array.Resize<string>(ref parts, parts.Length - 1);

                    line = string.Join("=", parts);
                }

                if (!m_Properties.ContainsKey(currentSection))
                    m_Properties.Add(currentSection, new Dictionary<string, List<string>>());

                if (!m_Properties[currentSection].ContainsKey(line))
                    m_Properties[currentSection].Add(line, new List<string>());

                m_Properties[currentSection][line].Add(val);

            }
            m_Properties = m_Properties;
        }*/
    }
}
