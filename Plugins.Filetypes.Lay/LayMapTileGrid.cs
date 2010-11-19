using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvilPlug.Filetypes.Lay
{
    public class LayMapTileGrid
    {
        public List<LayMapTile> Tiles = new List<LayMapTile>();
        public List<Point> Locations = new List<Point>();
        protected LayEntity m_ParentEntity = null;
        
        public LayEntity Owner
        {
            get
            {
                return m_ParentEntity;
            }
        }
        public LayMapTileGrid(LayEntity parentEntity)
        {
            m_ParentEntity = parentEntity;
        }
    }
}
