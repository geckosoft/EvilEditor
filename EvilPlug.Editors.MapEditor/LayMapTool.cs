using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilPlug.Filetypes.Lay;

namespace EvilPlug.Editors.MapEditor
{
    public class LayMapTool
    {
        protected LayFile Lay = null;
        protected LayMap Map = null;

        public LayMapTool(LayFile lf, LayMap lm)
        {
            Lay = lf;
            Map = lm;
        }

        public void UnselectAllTiles()
        {
            for (int x = 0; x < Map.Size.Width; x++)
            {
                for (int y = 0; y < Map.Size.Height; y++)
                {
                    ExtraTileInfo ti = (ExtraTileInfo)Map.Tiles[x, y].Tag;

                    ti.Selected = false;
                }
            }
        }

        public void SelectGrid(LayMapTileGrid grid)
        {
            for (int i = 0; i < grid.Tiles.Count; i++)
            {
                ExtraTileInfo ti = (ExtraTileInfo)grid.Tiles[i].Tag;
                ti.Selected = true;
            }
        }

        public List<LayMapTile> GetSelectedTiles()
        {
            List<LayMapTile> res = new List<LayMapTile>();
            for (int x = 0; x < Map.Size.Width; x++)
            {
                for (int y = 0; y < Map.Size.Height; y++)
                {
                    ExtraTileInfo ti = (ExtraTileInfo)Map.Tiles[x, y].Tag;

                    if (ti.Selected)
                        res.Add(Map.Tiles[x, y]);
                }
            }

            return res;
        }
    }
}
