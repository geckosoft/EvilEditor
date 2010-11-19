using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;

namespace EvilBase
{
    public class EvilPosition
    {
        public double X, Y, Z = 0;

        public EvilPosition(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public EvilPosition()
        {

        }

        public EvilPosition(string pos)
        {
            string[] parts = pos.Explode(",");

            X = double.Parse(parts[0]);
            Y = double.Parse(parts[1]);
            Z = double.Parse(parts[2]);
        }

        public override string ToString()
        {
            return X.ToString().Replace(",", ".") + "," + Y.ToString().Replace(",", ".") + "," + Z.ToString().Replace(",", ".");
        }
    }

    public class EvilOrientation : EvilPosition
    {
        public double Rotation = 0;

        public EvilOrientation(double x, double y, double z, double rot) : base(x,y,z)
        {
            Rotation = rot;
        }

        public EvilOrientation()
        {

        }

        public EvilOrientation(string or)
        {
            string[] parts = or.Explode(",");

            X = double.Parse(parts[0]);
            Y = double.Parse(parts[1]);
            Z = double.Parse(parts[2]);
            Rotation = double.Parse(parts[3]);
        }
        public override string ToString()
        {
            return X.ToString().Replace(",", ".") + "," + Y.ToString().Replace(",", ".") + "," + Z.ToString().Replace(",", ".") + "," + Rotation.ToString().Replace(",", ".");
        }
    }
}
