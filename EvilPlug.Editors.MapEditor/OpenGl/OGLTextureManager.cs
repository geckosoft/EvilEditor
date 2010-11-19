using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EvilPlug.Editors.MapEditor.OpenGl
{
    public class OGLTextureManager
    {
        public Dictionary<string, OGLTexture> Textures = new Dictionary<string, OGLTexture>();
        
        public OGLTexture LoadTexture(string filename)
        {
            if (Textures.ContainsKey(filename))
                return Textures[filename]; // already in there

            FileInfo fi = new FileInfo(filename);
            if (fi.Exists)
                return new OGLTexture(this, filename);
            else
                return null;
        }

        public OGLTexture LoadTexture(string filename, string key)
        {
            if (Textures.ContainsKey(key))
                return Textures[key]; // already in there


            FileInfo fi = new FileInfo(filename);
            if (fi.Exists)
                return new OGLTexture(this, filename, key);
            else
                return null;
        }

        internal void Add(OGLTexture oGLTexture, string key)
        {
            Textures.Add(key, oGLTexture);
        }

        internal OGLTexture GetTexture(string filename)
        {
            if (Textures.ContainsKey(filename))
                return Textures[filename];

            return null;
        }
    }
}
