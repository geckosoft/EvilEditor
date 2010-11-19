using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing;
using Extensions;

namespace EvilPlug.Filetypes.Lay
{
    public class LayMap
    {
        public Size Size = new Size(0, 0);
        public LayMapTile[,] Tiles;
        protected int m_X, m_Y = -1;
        protected LayMapTile[,] m_tmpTiles;
        protected List<LayProperty> m_TileProperties = new List<LayProperty>();

        public LayMap(LayFile lf)
        {
            bool foundMap = false;
            string[] tempStrings;

            // Load the map
            for (int i = 0; i < lf.Properties.Count; i++)
            {
                LayProperty prop = lf.Properties[i];

                if (prop.Key == "GridDimensions")
                {
                    tempStrings = prop.Value.Explode(",");

                    if (tempStrings.Length != 2)
                        throw new Exception("Invalid map: size incorrect");


                    Size = new Size(int.Parse(tempStrings[0]), int.Parse(tempStrings[1]));
                    Tiles = new LayMapTile[Size.Width, Size.Height];
                    m_tmpTiles = new LayMapTile[Size.Width, Size.Height];
                    foundMap = true;
                    continue;
                }

                if (!foundMap)
                    continue;

                if (prop.Key == "")
                    continue;

                if (prop.Key == "DynamicATNData")
                {
                    break;
                }
                m_Y++;

                string[] parts = prop.Key.Explode(",");

                m_X = 0;

                try
                {
                    foreach (string part in parts)
                    {
                        Tiles[m_X, m_Y] = new LayMapTile(part, m_X, m_Y);
                        m_tmpTiles[m_X, m_Y] = Tiles[m_X, m_Y];

                        m_X++;
                        
                        LayEntity le = lf.FindEntityByGridLocation(m_X-1, m_Y);
                        if (le != null)
                        {
                            le.TilesGrid.Tiles.Add(Tiles[m_X-1, m_Y]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ex = ex;
                }
                m_TileProperties.Add(prop);

                string mapPart = prop.Key;
                mapPart = mapPart.Replace("20006A", "20000A");
                prop.Key = mapPart;
            }

            if (!foundMap)
                throw new Exception("No map data found!");

            for (int x = 0; x < Size.Width; x++)
            {
                for (int y = 0; y < Size.Height; y++)
                {
                   // Tiles[x, y] = m_tmpTiles[Size.Width - x - 1, y];       // something for later :P             
                }

            }
        }

        // Pushes the updated fields into the LayFile object
        public void ApplyChanges()
        {
            for (int y = 0; y < m_Y ; y++)
            {
                LayProperty prop = m_TileProperties[y];
                prop.Key = "";
                for (int x = 0; x < m_X; x++)
                {
                    if (x + 1 < m_X)
                        prop.Key += Tiles[x, y].RawId + ",";
                    else
                        prop.Key += Tiles[x, y].RawId;
                }
            }
        }
    }
}
