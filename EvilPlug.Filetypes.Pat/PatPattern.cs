using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;

namespace EvilPlug.Filetypes.Pat
{
    public class PatPattern
    {
        public List<string> Fields = new List<string>();

        public PatPattern(string patternLine)
        {
            string[] parts = patternLine.Explode(",");

            foreach (string part in parts)
            {
                string px = part;
                px = px.Trim();
                Fields.Add(px);
            }
        }
    }
}
