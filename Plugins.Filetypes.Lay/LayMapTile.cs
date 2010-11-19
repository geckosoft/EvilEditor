using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvilPlug.Filetypes.Lay
{
    public class LayMapTile
    { 
        protected string m_TileValue = "";
        protected Point m_Position = new Point(0, 0);

        public Point Position
        {
            get
            {
                return m_Position;
            }
        }
        public Object Tag = null;

        public LayMapTile(string tileValue, int x, int y)
        {
            m_TileValue = tileValue;
            m_Position = new Point(x, y);
        }

        public string Id
        {
            get
            {
                return m_TileValue.Substring(0, m_TileValue.Length - 1);
            }
            set
            {
                m_TileValue = value + "A";
            }
        }

        public string RawId
        {
            get
            {
                return m_TileValue;
            }
            set
            {
                m_TileValue = value;
            }
        }
    }
}
