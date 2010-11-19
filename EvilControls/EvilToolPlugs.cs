using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using EvilBase;

namespace EvilControls
{
    public partial class EvilToolPlugs : Component
    {
        protected EvilPlugList m_PluginList = null;
        protected Timer m_Timer = new Timer();
        protected List<IPlugTool> m_Tools = new List<IPlugTool>();
        protected Form m_Parent = null;
        protected ToolStripMenuItem m_ToolsMenu = null;
        public EvilToolPlugs()
        {
            InitializeComponent();

            InitLoadTimer();
        }

        private void InitLoadTimer()
        {
            m_Timer.Interval = 100;
            m_Timer.Enabled = true;
            m_Timer.Tick += new EventHandler(m_Timer_Tick);
        }

        void m_Timer_Tick(object sender, EventArgs e)
        {
            m_Timer.Enabled = false;
            m_Timer.Dispose();

            LoadTools();
        }

        public EvilToolPlugs(IContainer container)
        {
            InitializeComponent();
            container.Add(this);

            InitLoadTimer();
        }

        private void LoadTools()
        {
            if ((DesignMode) || (EvilTools.DesignMode))
                return;
            List<Type> tools = m_PluginList.GetPluginTypes(typeof(IPlugTool));

            foreach (Type t in tools)
            {
                if (t.IsInterface)
                    continue;

                IPlugTool et = (IPlugTool)Activator.CreateInstance(t);


                et.Load(m_Parent, m_ToolsMenu);
                m_Tools.Add(et);
            }

        }

        public Form ParentForm
        {
            get
            {
                return m_Parent;
            }
            set
            {
                m_Parent = value;
            }
        }

        public ToolStripMenuItem ToolsMenu
        {
            get
            {
                return m_ToolsMenu;
            }
            set
            {
                m_ToolsMenu = value;
            }
        }

        public EvilPlugList PluginList
        {
            get
            {
                return m_PluginList;
            }
            set
            {
                m_PluginList = value;
            }
        }
    }
}
