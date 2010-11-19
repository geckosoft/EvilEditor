using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilPlug.Filetypes.Lay;
using EvilPlug.Editors.MapEditor.OpenGl;
using EvilBase;
namespace EvilPlug.Editors.MapEditor
{
    public class ExtraTileInfo
    {
        public bool Selected = false;
        public LayMapTile Parent = null;
        public OGLTexture Texture = null;
        public OGLTextureManager TextureManager = null;
        public ExtraTileInfo (LayMapTile tile, OGLTextureManager manager)
        {
            Parent = tile;
            TextureManager = manager;
            Texture = TextureManager.LoadTexture(EvilTools.GetExecutingPath(@"MapEditor\Tiles\" + tile.Id + ".png"));
            if (Texture == null)
                Texture = TextureManager.LoadTexture(EvilTools.GetExecutingPath(@"MapEditor\Tiles\unknown.png"));
        }

    }
}
