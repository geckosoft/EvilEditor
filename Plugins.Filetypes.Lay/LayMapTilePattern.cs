using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Extensions;

namespace EvilPlug.Filetypes.Lay
{
    public class LayMapTilePattern
    {
        // public List<LayMapTile> Tiles = new List<LayMapTile>();
        protected Point m_Location = new Point();

        protected LayEntity m_ParentEntity = null;
        protected LayProperty m_Filename = null;
        protected LayProperty m_Index = null;
        protected LayProperty m_Status = null;

        public Point Location
        {
            get
            {
                return m_Location;
            }
            set
            {
                m_ParentEntity.GetProperty("PatternX").Value = (value.X + 1).ToString();
                m_ParentEntity.GetProperty("PatternY").Value = (value.Y + 1).ToString();

                m_Location = value;
            }
        }
        public string Filename
        {
            get
            {
                return m_Filename.Value;
            }
            set
            {
                m_Filename.Value = value;
            }
        }
        public string Index
        {
            get
            {
                return m_Index.Value;
            }
            set
            {
                m_Index.Value = value;
            }
        }
        public string Status
        {
            get
            {
                return m_Status.Value;
            }
            set
            {
                m_Status.Value = value;
            }
        }
        public LayEntity Owner
        {
            get
            {
                return m_ParentEntity;
            }
        }

        public LayMapTilePattern(LayEntity parentEntity)
        {
            m_ParentEntity = parentEntity;

            m_Filename = parentEntity.GetProperty("PatternFilename");
            m_Index = parentEntity.GetProperty("PatternIndex");
            m_Status = parentEntity.GetProperty("Status");
            int x = parentEntity.GetProperty("PatternX").Value.ToInteger()-1;
            int y = parentEntity.GetProperty("PatternY").Value.ToInteger()-1;
            m_Location = new Point(x, y);
        }

    }
}
