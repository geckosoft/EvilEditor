using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilBase;
using Extensions;

namespace EvilPlug.Filetypes.Pat
{
    public class PatProcessor
    {
        public List<PatProperty> Properties = new List<PatProperty>();

        public PatProcessor(string content)
        {
            content = content.Replace("\r\n", "\n");
            string[] lines = content.Explode("\n");

            foreach (string line in lines)
            {
                Properties.Add(new PatProperty(line));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (PatProperty prop in Properties)
            {
                if (prop.Deleted)
                    continue;
                sb.Append(prop.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
