using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;

namespace EvilPlug.Filetypes.Pat
{
    public class PatProperty
    {
        public PatProperty(string line)
        {
            if (!line.Contains("="))
            {
                Key = line;
                Value = null;
            }
            else
            {
                string[] parts = line.Explode("=");
                Value = parts[parts.Length - 1];
                Array.Resize<string>(ref parts, parts.Length - 1);

                Key = string.Join("=", parts);
            }
        }

        public string Key = "";
        public string Value = null;
        public bool Deleted = false;
        public override string ToString()
        {
            if (Value == null)
                return Key;
            else
                return Key + "=" + Value;
        }
        public static implicit operator string(PatProperty prop)
        {
            return prop.Value;
        }
    }
}
