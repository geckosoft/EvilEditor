using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Reflection;
using EvilBase;

namespace EvilControls
{
    public partial class EvilPlugList : Component
    {
        protected List<Type> m_Plugins = new List<Type>();
        public EvilPlugList()
        {
            InitializeComponent();
            LoadPluginTypes();
        }

        public EvilPlugList(IContainer container)
        {
            container.Add(this);
            LoadPluginTypes();
        }

        protected void LoadPluginTypes()
        {
            if ((!EvilTools.DesignMode) && (!DesignMode))
            {
                m_Plugins = PlugMaster.LoadPlugs();
            }
        }

        public List<Type> GetPluginTypes(Type basePluginType)
        {
            List<Type> plugs = new List<Type>();

            foreach (Type plug in m_Plugins)
            {
                Type[] interfaces = plug.GetInterfaces();

                foreach (Type it in interfaces)
                {
                    if (it == basePluginType)
                        plugs.Add(plug);
                }
            }

            return plugs;
        }

        public List<Type> PluginTypes
        {
            get
            {
                return m_Plugins;
            }
        }

    }
}
