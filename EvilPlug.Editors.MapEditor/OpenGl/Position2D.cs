using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvilPlug.Editors.MapEditor.OpenGl
{
    public struct Position2D
    {
        public int X;
        public int Y;

        public Position2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <param name="pos">Format: x,y</param>
        public Position2D(string pos)
        {
            string[] parts = pos.Split(',');
            if (parts.Length != 2)
                throw new ArgumentException("Invalid position feeded into Position2D (" + pos + ")");

            try
            {
                X = Convert.ToInt32(parts[0]);
                Y = Convert.ToInt32(parts[1]);
            }
            catch
            {
                throw new ArgumentException("Invalid position feeded into Position2D (" + pos + ")");
            }
        }

        public static bool operator !=(Position2D first, Position2D other)
        {
            if ((first.X == other.X) && (first.Y == other.Y))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Position2D first, Position2D other)
        {
            if ((first.X == other.X) && (first.Y == other.Y))
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object o)
        {
            if (o.GetType() == typeof(Position2D))
            {
                return (Position2D)o == this;
            }
            return false;
        }
        public static Position2D From(int x, int y)
        {
            return new Position2D(x, y);
        }
        public static Position2D From(string pos)
        {
            return new Position2D(pos);
        }
        public override string ToString()
        {
            return X.ToString() + "," + Y.ToString();
        }
        /*
        public float Xf(int width)
        {
            return 1 / X * x;
        }
        public float Yf(int height)
        {
            return 1 / Y * y;
        }
        */
        public override int GetHashCode()
        {
            string key = X + ":" + Y;
            return key.ToString().GetHashCode();
        }
    }
}
