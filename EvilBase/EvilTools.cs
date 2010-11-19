using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace EvilBase
{
    public static class EvilTools
    {
        public static bool DesignMode
        {
            get
            {
                return (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToLower() == "devenv");
            }
        }


        public static Control CloneControl(Control o)
        {
            Control clone = (Control)CloneObject(o);

            clone.SuspendLayout();
            for (int i = 0; i < o.Controls.Count; i++)
            {
                Control obj = o.Controls[i];
                //clone.Controls.Remove(obj);
                Control clonedObj = CloneControl(obj);
                clone.Controls.Add(clonedObj);
            }
            clone.ResumeLayout();
            clone.PerformLayout();

            return clone;
        }

        public static object CloneObject(object o)
        {
            Type t = o.GetType();
            PropertyInfo[] properties = t.GetProperties();

            Object p = t.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, o, null);

            foreach (PropertyInfo pi in properties)
            {
                if (pi.CanWrite)
                {
                    pi.SetValue(p, pi.GetValue(o, null), null);
                }
            }

            return p;
        }

        public static string ExecutingPath
        {
            get
            {
                String strPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                return strPath;
            }
        }

        public static string GetExecutingPath(string relativePath)
        {
            String strPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            strPath = System.IO.Path.Combine(strPath, relativePath);
            return strPath;
        }


        public static string GetTextFileContents(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);
            string text = streamReader.ReadToEnd();
            streamReader.Close();

            // UInt32 hash = GenerateATNHash("EVENT_OUT_OF_MONEY".ToLower());
            return text;
        }


        public static void SaveTextToFile(string filePath, string text)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(text);
                sw.Flush();
                sw.Close();
            }
        }

        public static UInt32 GenerateATNHash(string filename)
        {
            UInt32 c_uPrime = 16777619;

         //  Byte buf      = (Byte *)filename;
           int   bufLength   = filename.Length;

           UInt32 uHash = 2166136261;
           unchecked
           {

               for (int i = 0; i < bufLength; i++)
               {
                   uHash *= c_uPrime;
                   uHash ^= (UInt32)((Byte)filename[i]);

                   //buf++;
               }
           }
           return uHash;
        }
    }
}
