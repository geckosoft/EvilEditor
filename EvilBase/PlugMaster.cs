using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
namespace EvilBase
{
    public static class PlugMaster
    {
        public static List<Type> LoadPlugs()
        {
            DirectoryInfo dInfo = new DirectoryInfo(Environment.CurrentDirectory);
            FileInfo[] files = dInfo.GetFiles("*.dll");
            List<Type> plugInAssemblyList = new List<Type>();

            if (null != files)
            {
                foreach (FileInfo file in files)
                {
                    try
                    {
                        Assembly nAs = Assembly.LoadFile(file.FullName);
                        Type[] types = nAs.GetTypes();
                        foreach (Type type in types)
                        {
                            Type[] interfaces = type.GetInterfaces();
                            foreach(Type it in interfaces)
                            {
                                if (it == typeof(IPlugBase))
                                    plugInAssemblyList.Add(type);
                                
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }

            return plugInAssemblyList;

        }
    }
}
