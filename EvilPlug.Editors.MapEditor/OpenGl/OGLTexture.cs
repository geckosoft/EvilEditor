using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Tao.OpenGl;

namespace EvilPlug.Editors.MapEditor.OpenGl
{
    public class OGLTexture
    {
        public Bitmap Source;
        public Dimension2D Size = new Dimension2D(0, 0);
        public int TextureId = 0;
        public string Filename = "";
        public OGLTexture(OGLTextureManager manager, string filename)
        {
            Source = (Bitmap)Bitmap.FromFile(filename);

            CreateOpenGlSurface(Source);
            Filename = filename;
            manager.Add(this, Filename);
        }
        public OGLTexture(OGLTextureManager manager, string filename, string key)
        {
            Source = (Bitmap)Bitmap.FromFile(filename);

            CreateOpenGlSurface(Source);
            Filename = filename;
            manager.Add(this, key);
        }

        private void CreateOpenGlSurface(Bitmap Source)
        {
            try
            {
                Bitmap tmp = Source;
                int[] m_Textures = new int[1];


                tmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                System.Drawing.Imaging.BitmapData bitmapdata;
                Rectangle rect = new Rectangle(0, 0, tmp.Width, tmp.Height);
                bitmapdata = tmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                Gl.glEnable(Gl.GL_TEXTURE_2D);
                Gl.glGenTextures(1, m_Textures);
                TextureId = m_Textures[0];
                Gl.glEnable(Gl.GL_ALPHA_TEST);
                Gl.glAlphaFunc(Gl.GL_GREATER, 0.0f);
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, TextureId);
                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);
                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);

                //Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_DECAL);
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA8, tmp.Width, tmp.Height,
                    0, Gl.GL_BGRA, Gl.GL_UNSIGNED_BYTE, bitmapdata.Scan0);
                Gl.glDisable(Gl.GL_ALPHA_TEST);
                Gl.glDisable(Gl.GL_TEXTURE_2D);

                Size.Width = tmp.Width;
                Size.Height = tmp.Height;
                tmp.UnlockBits(bitmapdata);
                tmp.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Could not load requested texture.", ex);
                // TODO Maybe we should just log the error?
            }
        }
    }
}
