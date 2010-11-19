using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Drawing;

namespace EvilPlug.Editors.MapEditor.OpenGl
{
    public static class OGLTools
    {
        static bool m_2DMode = false;
        static Dictionary<int, bool> m_Capabilities = new Dictionary<int, bool>();
        public static SimpleOpenGlControl oGL = null;

        public static bool RestoreOrtho()
        {

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glDisable(Gl.GL_DEPTH_TEST);

            Gl.glPushMatrix();
            Gl.glLoadIdentity();
            Gl.glOrtho(0, oGL.Width, oGL.Height, 0, -1, 1);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glPushMatrix();

            m_2DMode = true;

            return true;
        }
        public static bool glEnable2D(bool force)
        {
            if ((m_2DMode) && (!force)) { return false; }
            RestoreOrtho();

            m_2DMode = true;
            return true;
        }

        public static bool glEnable2D()
        {
            if (m_2DMode) { return false; }
            RestoreOrtho();

            m_2DMode = true;
            return true;
        }

        public static bool glDisable2D()
        {
            if (!m_2DMode) { return false; }

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glPopMatrix();
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glPopMatrix();
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            m_2DMode = false;
            return true;
        }

        public static bool IsCapEnabled(int capID)
        {
            if (!m_Capabilities.ContainsKey(capID))
            {
                return false;
            }

            return (bool)m_Capabilities[capID];
        }

        public static bool glDisable(int capability)
        {
            if (IsCapEnabled(capability))
            {
                Gl.glDisable(capability);
                m_Capabilities[capability] = false;
                return true;
            }

            return false;
        }

        public static bool glEnable(int capability)
        {
            if (!IsCapEnabled(capability))
            {
                Gl.glEnable(capability);
                m_Capabilities[capability] = true;
                return true;
            }

            return false;
        }
        static int m_CurrentTextureID = -9999;

        public static void DrawFilledRectangle(Color color, Position2D start, Dimension2D size)
        {
            OGLTools.glDisable(Gl.GL_TEXTURE_2D);
            OGLTools.glEnable(Gl.GL_ALPHA);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
            Gl.glColor4f(1.0f, 1.0f, 1.0f, 1f);

            Gl.glPushMatrix();
            Gl.glTranslated(start.X, start.Y, 0);

            float x1, y1;
            /*
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f((float)color.R / 255f, (float)color.G / 255f, (float)color.B / 255f);
            Gl.glVertex2f(0f, 0f);
            Gl.glVertex2f(0, size.Height);
            Gl.glVertex2f(size.Width, size.Height);
            Gl.glVertex2f(size.Width, 0);
            Gl.glVertex2f(0f, 0f);
            Gl.glEnd();
            */
            float[] Vertices = new float[] { 0, 0, 0, (float)size.Height, (float)size.Width, (float)size.Height, (float)size.Width, 0, 0, 0 };
            float[] Indices = { 0, 1, 2, 3, 4 };
             
            
            
            //Load the arrays 
            Gl.glColor3f((float)color.R / 255f, (float)color.G / 255f, (float)color.B / 255f);
            Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY);
            Gl.glVertexPointer(2, Gl.GL_FLOAT, 0, Vertices);
            Gl.glDrawArrays(Gl.GL_QUADS, 0, Indices.Length);
            Gl.glDisableClientState(Gl.GL_VERTEX_ARRAY);

            // disable blending
            glDisable(Gl.GL_BLEND);
            OGLTools.glDisable(Gl.GL_ALPHA);                
            


            Gl.glPopMatrix(); // Need to optimize this like glPopMatrix(sessionID);

        }
        public static void DrawRectangle(Color color, Position2D start, Dimension2D size)
        {
            //glEnable2D();
            OGLTools.glDisable(Gl.GL_TEXTURE_2D);
            OGLTools.glEnable(Gl.GL_ALPHA);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
            Gl.glColor4f(1.0f, 1.0f, 1.0f, 1f);
           // start.X += size.Width;

            Gl.glPushMatrix();
            Gl.glTranslated(start.X, start.Y, 0);
            
            float x1, y1;
            
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f((float)color.R / 255f, (float)color.G / 255f, (float)color.B / 255f);
            Gl.glVertex2f(0f, 0f);
            Gl.glVertex2f(0, size.Height);
            Gl.glVertex2f(size.Width, size.Height);
            Gl.glVertex2f(size.Width, 0);
            Gl.glVertex2f(0f, 0f);
            Gl.glEnd();
            

            // disable blending
            glDisable(Gl.GL_BLEND);
            OGLTools.glDisable(Gl.GL_ALPHA);

            Gl.glPopMatrix(); // Need to optimize this like glPopMatrix(sessionID);

        }

        public static void DrawLine(Color color, Position2D start, Dimension2D tSize)
        {
            OGLTools.glDisable(Gl.GL_TEXTURE_2D);
            OGLTools.glEnable(Gl.GL_ALPHA);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
            Gl.glColor4f(1.0f, 1.0f, 1.0f, 1f);

            Gl.glPushMatrix();
            Gl.glTranslated(start.X, start.Y, 0);

            float x1, y1;


            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3f(color.R / 255, color.G / 255, color.B / 255);
            Gl.glVertex2f(0f, 0f);
            Gl.glColor3f(color.R / 255, color.G / 255, color.B / 255);
            Gl.glVertex2f(tSize.Width, tSize.Height);
            Gl.glEnd();

            // disable blending
            glDisable(Gl.GL_BLEND);
            OGLTools.glDisable(Gl.GL_ALPHA);

            Gl.glPopMatrix(); // Need to optimize this like glPopMatrix(sessionID);

        }
        public static void DrawTexture(OGLTexture txt, Position2D texturePosition, Dimension2D textureSize, Position2D targetPosition, Dimension2D targetSize, float Alpha)
        {
            /*if ((targetPosition.X < 0) || (targetPosition.X >= oGL.Width))
                return;
            if ((targetPosition.Y < 0) || (targetPosition.Y >= oGL.Height))
                return;
            if ((targetPosition.X + targetSize.Width < 0) || (targetPosition.X + targetSize.Width >= oGL.Width))
                return;
            if ((targetPosition.Y + targetSize.Height < 0) || (targetPosition.Y + targetSize.Height >= oGL.Height))
                return;*/
            glEnable2D();
            glEnable(Gl.GL_ALPHA);
            OGLTools.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
            Gl.glColor4f(1.0f, 1.0f, 1.0f, Alpha);

            Gl.glPushMatrix();
            Gl.glTranslated(targetPosition.X, targetPosition.Y, 0);

            if (m_CurrentTextureID != (int)txt.TextureId)
            {
                m_CurrentTextureID = (int)txt.TextureId;

                Gl.glBindTexture(Gl.GL_TEXTURE_2D, m_CurrentTextureID);
            }

            float x1, y1;


            Gl.glBegin(Gl.GL_QUADS);

            // Extract bottom left position
            //x1 = (1.0f / (float)txt.Size.Width * (float)texturePosition.X) - txt.Size.GetFloatingX(textureSize.Width - txt.Size.Width);
            //y1 = (1.0f / (float)txt.Size.Height * (float)texturePosition.Y) - txt.Size.GetFloatingY(textureSize.Width - txt.Size.Height);
            x1 = 1 / (float)txt.Size.Width * (float)texturePosition.X;
            y1 = 1 / (float)txt.Size.Height * (float)texturePosition.Y;
            Gl.glTexCoord2f(x1, y1 * -1);
            Gl.glVertex2i(0, 0);

            // Extract bottom right
            //x1 = (1.0f / (float)txt.Size.Width * (float)texturePosition.X) - txt.Size.GetFloatingX(textureSize.Width);
            //y1 = (1.0f / (float)txt.Size.Height * (float)texturePosition.Y) - txt.Size.GetFloatingY(textureSize.Height - txt.Size.Height);
            x1 = 1 / (float)txt.Size.Width * ((float)texturePosition.X + (float)textureSize.Width);
            y1 = 1 / (float)txt.Size.Height * (float)texturePosition.Y;
            Gl.glTexCoord2f(x1, y1 * -1);
            Gl.glVertex2i(targetSize.Width, 0);
            // Extract top right
            //x1 = (1.0f / (float)txt.Size.Width * (float)texturePosition.X) - txt.Size.GetFloatingX(textureSize.Width);
            //y1 = (1.0f / (float)txt.Size.Height * (float)texturePosition.Y) - txt.Size.GetFloatingY(textureSize.Height);
            x1 = 1 / (float)txt.Size.Width * ((float)texturePosition.X + (float)textureSize.Width);
            y1 = 1 / (float)txt.Size.Height * ((float)texturePosition.Y + (float)textureSize.Height);
            Gl.glTexCoord2f(x1, y1 * -1);
            Gl.glVertex2i(targetSize.Width, targetSize.Height);
            // Extract top left position
            //x1 = (1.0f / (float)txt.Size.Width * (float)texturePosition.X) - txt.Size.GetFloatingX(textureSize.Width - txt.Size.Width);
            //y1 = (1.0f / (float)txt.Size.Height * (float)texturePosition.Y) - txt.Size.GetFloatingY(textureSize.Height);
            x1 = 1 / (float)txt.Size.Width * (float)texturePosition.X;
            y1 = 1 / (float)txt.Size.Height * ((float)texturePosition.Y + (float)textureSize.Height);
            Gl.glTexCoord2f(x1, y1 * -1);
            Gl.glVertex2i(0, targetSize.Height + 0);
            Gl.glEnd();

            // disable blending
            glDisable(Gl.GL_BLEND);

            Gl.glPopMatrix(); // Need to optimize this like glPopMatrix(sessionID);
        }

        public static void DrawTexture(OGLTexture txt, Position2D texturePosition, Dimension2D textureSize, Position2D srcPosition, Position2D targetPosition, float Alpha)
        {
            Dimension2D tSize = new Dimension2D(targetPosition.X - srcPosition.X, targetPosition.Y - srcPosition.Y);
            
            DrawTexture(txt, texturePosition, textureSize, srcPosition, tSize, Alpha);

        }
    }
}
