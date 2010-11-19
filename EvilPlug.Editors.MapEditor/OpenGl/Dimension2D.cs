using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvilPlug.Editors.MapEditor.OpenGl
{
    public struct Dimension2D
    {
        public int Height;
        public int Width;

        public Dimension2D(int w, int h)
        {
            Height = h;
            Width = w;
        }
        /// <param name="size">Format: widthXheight Example: 32x32</param>
        public Dimension2D(string size)
        {
            size = size.ToLower();

            string[] parts = size.Split('x');
            if (parts.Length != 2)
                throw new ArgumentException("Invalid size feeded into Dimension2D (" + size + ")");

            try
            {
                Width = Convert.ToInt32(parts[0]);
                Height = Convert.ToInt32(parts[1]);
            }
            catch
            {
                throw new ArgumentException("Invalid position feeded into Dimension2D (" + size + ")");
            }
        }

        public static bool operator !=(Dimension2D first, Dimension2D other)
        {
            if ((first.Width == other.Width) && (first.Height == other.Height))
            {
                return false;
            }
            return true;
        }
        public static bool operator ==(Dimension2D first, Dimension2D other)
        {
            if ((first.Width == other.Width) && (first.Height == other.Height))
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object o)
        {
            if (o.GetType() == typeof(Dimension2D))
            {
                return (Dimension2D)o == this;
            }
            return false;
        }
        public static Dimension2D From(int w, int h)
        {
            return new Dimension2D(w, h);
        }
        public static Dimension2D From(string size)
        {
            return new Dimension2D(size);
        }
        public override string ToString()
        {
            return Width.ToString() + "," + Height.ToString();
        }

        public override int GetHashCode()
        {
            string key = Width + ":" + Height;
            return key.ToString().GetHashCode();
        }

        public float GetFloatingX(int width)
        {
            float res = 1.0f;
            res = res / (float)Width;
            res = res * (float)width;
            return res;
        }
        public float GetFloatingY(int height)
        {
            float res = 1.0f;
            res = res / (float)Height;
            res = res * (float)height;
            return res;
        }
    }
}
