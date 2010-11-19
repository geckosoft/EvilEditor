using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilBase;
using Extensions;

namespace EvilPlug.Filetypes.Lay
{
    public class LayEntityStats
    {
        internal LayProperty m_Health;
        internal LayProperty m_Loyalty;
        internal LayProperty m_Smarts;
        internal LayProperty m_Attention;
        internal LayProperty m_Endurance;
        internal LayProperty m_Lives;

        public string Health
        {
            get
            {
                if (m_Health == null)
                    return "";

                return m_Health.Value.Explode(",")[1];
            }
            set
            {
                if (m_Health == null)
                    return;
                m_Health.Value = "Health," + value;
            }
        }
        public string Loyalty
        {
            get
            {
                if (m_Loyalty == null)
                    return "";

                return m_Loyalty.Value.Explode(",")[1];
            }
            set
            {
                if (m_Loyalty == null)
                    return;
                m_Loyalty.Value = "Loyalty," + value;
            }
        }
        public string Smarts
        {
            get
            {
                if (m_Smarts == null)
                    return "";

                return m_Smarts.Value.Explode(",")[1];
            }
            set
            {
                if (m_Smarts == null)
                    return;
                m_Smarts.Value = "Smarts," + value;
            }
        }
        public string Attention
        {
            get
            {
                if (m_Attention == null)
                    return "";

                return m_Attention.Value.Explode(",")[1];
            }
            set
            {
                if (m_Attention == null)
                    return;
                m_Attention.Value = "Attention," + value;
            }
        }
        public string Endurance
        {
            get
            {
                if (m_Endurance == null)
                    return "";

                return m_Endurance.Value.Explode(",")[1];
            }
            set
            {
                if (m_Endurance == null)
                    return;

                m_Endurance.Value = "Endurance," + value;
            }
        }
        public string Lives
        {
            get
            {
                if (m_Lives == null)
                    return "0";

                return m_Lives.Value;
            }
            set
            {
                if (m_Lives == null)
                    return;

                m_Lives.Value = value;
            }
        }
    }
    public class LayEntity
    {
        protected string m_DescriptionID = "";
        protected List<LayProperty> m_Properties = new List<LayProperty>();

        public string EntityDescriptionID
        {
            get
            {
                return GetProperty("EntityDescriptionID").Value;
            }
        }
        public string EntityID
        {
            get
            {
                return GetProperty("EntityID").Value;
            }
        }
        public string Orientation
        {
            get
            {
                return GetProperty("Orientation").Value;
            }
            set
            {
                GetProperty("Orientation").Value = value;
                
            }
        }
        public string Position
        {
            get
            {
                return GetProperty("Position").Value;
            }
            set
            {
                GetProperty("Position").Value = value;
            }
        }
        public string SourcePosition
        {
            get
            {
                if (GetProperty("SourcePosition") == null)
                    return "";
                return GetProperty("SourcePosition").Value;
            }
            set
            {
                if (GetProperty("SourcePosition") == null)
                    return;

                GetProperty("SourcePosition").Value = value;
            }
        }
        public LayEntityStats Stats = new LayEntityStats();
        public LayMapTileGrid TilesGrid = null;//= new LayMapTileGrid();
        public LayMapTilePattern Pattern = null;//= new LayMapTileGrid();
        public string Name
        {
            get
            {
                if (GetProperty("Name") == null)
                    return null;

                return GetProperty("Name").Value;
            }

            set
            {
                if (GetProperty("Name") == null)
                    return;

                GetProperty("Name").Value = value;
            }
        }
        public LayEntity(List<LayProperty> properties, int index)
        {
            for (int i = index; i < properties.Count; i++)
            {
                LayProperty prop = properties[i];
                switch (prop.Key)
                {
                    case "EntityDescriptionID":
                        if (m_DescriptionID != "")
                        {
                            ProcessData();
                            TilesGrid = new LayMapTileGrid(this);
                            if (GetProperty("PatternMatchData") != null)
                                Pattern = new LayMapTilePattern(this);
                            ProcessGrids();
                            ProcessPattern();
                            return;
                        }
                        m_DescriptionID = prop.Value;
                        break;

                    case "EndEntityList":
                        ProcessData();
                        TilesGrid = new LayMapTileGrid(this);
                        if (GetProperty("PatternMatchData") != null)
                            Pattern = new LayMapTilePattern(this);
                        ProcessGrids();
                        ProcessPattern();
                        return;
                }

                m_Properties.Add(prop);
            }
            ProcessData();

            TilesGrid = new LayMapTileGrid(this);
            if (GetProperty("PatternMatchData") != null)
                Pattern = new LayMapTilePattern(this);
            ProcessGrids();
            ProcessPattern();
        }

        private void ProcessPattern()
        {
            //throw new NotImplementedException();
            LayProperty pattern = GetProperty("PatternMatchData");
            if (pattern == null)
                return;

            Pattern = new LayMapTilePattern(this);
        }

        private void ProcessGrids()
        {
            List<LayProperty> gridTiles = GetProperties("GridTiles");

            if (gridTiles.Count == 0)
                return;

            foreach (LayProperty prop in gridTiles)
            {
                string[] locs = prop.Value.Explode(",");

                for (int x = 0; x < locs.Length; x = x + 2)
                {
                    string posX = locs[x];
                    string posY = locs[x + 1];
                    TilesGrid.Locations.Add(new System.Drawing.Point(posX.ToInteger(), posY.ToInteger()));
                }
            }
        }

        protected LayProperty FindScaleProperty(string name)
        {
            List<LayProperty> props = GetProperties("Scale");

            foreach (LayProperty prop in props)
            {
                if (prop.Value.Contains(name))
                    return prop;
            }

            return null;
        }

        protected void ProcessData()
        {
                Stats.m_Lives = GetProperty("NumLives"); // Henchmen only!

                Stats.m_Health = FindScaleProperty("Health");
                Stats.m_Loyalty = FindScaleProperty("Loyalty");
                Stats.m_Smarts = FindScaleProperty("Smarts");
                Stats.m_Attention = FindScaleProperty("Attention");
                Stats.m_Endurance = FindScaleProperty("Endurance");
                if ((Stats.m_Smarts == null) && (EntityDescriptionID.ToInteger() < 1000))
                    Stats.m_Smarts = null;
        }
        /// <summary>
        /// On next save, the entity its properties won't be saved
        /// </summary>
        public void Delete()
        {
            for (int i = 0; i < m_Properties.Count; i++)
            {
                m_Properties[i].Deleted = true;
            }
            m_Deleted = true;
        }
        /// <summary>
        /// Do not delete this anymore
        /// </summary>
        public void UndoDelete()
        {
            for (int i = 0; i < m_Properties.Count; i++)
            {
                m_Properties[i].Deleted = false;
            }
            m_Deleted = false;
        }
        protected bool m_Deleted = false;

        public bool Deleted
        {
            get
            {
                return m_Deleted;
            }
        }
        public LayProperty GetProperty(string key)
        {
            foreach (LayProperty prop in m_Properties)
            {
                if (prop.Key == key)
                    return prop;
            }

            return null;
        }
        public LayProperty GetProperty(string key, int index)
        {
            int cur = 0;

            foreach (LayProperty prop in m_Properties)
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
        public List<LayProperty> GetProperties(string key)
        {
            List<LayProperty> res = new List<LayProperty>();

            foreach (LayProperty prop in m_Properties)
            {
                if (prop.Key == key)
                    res.Add(prop);
            }

            return res;
        }
    }
}
