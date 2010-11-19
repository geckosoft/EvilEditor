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
    public partial class EvilFileTypes : Component
    {
        protected OpenFileDialog m_Open = null;
        protected SaveFileDialog m_Save = null;
        protected EvilPlugList m_PluginList = null;
        protected Timer m_Timer = new Timer();

        public EvilFileTypes()
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
            LoadFilters();
        }

        public EvilFileTypes(IContainer container)
        {
            InitializeComponent();
            container.Add(this);

            InitLoadTimer();
        }

        private void LoadFilters()
        {
            if ((DesignMode) || (EvilTools.DesignMode))
                return;

            string filter = "";

            List<Type> types = m_PluginList.GetPluginTypes(typeof(IPlugFileType));

            foreach (Type type in types)
            {
                IPlugFileType ft = (IPlugFileType)Activator.CreateInstance(type);

                if (filter != "")
                    filter += "|";

                filter += ft.ExtDescription + " (" + ft.Filter + ")|" + ft.Filter;
            }

            if (filter == "")
                filter += "All Files (*.*)|*.*";
            else
                filter += "|All Files (*.*)|*.*";

            m_Open.Filter = filter;
            m_Save.Filter = filter;
        }

        public OpenFileDialog OpenFileDialog
        {
            get
            {
                return m_Open;
            }
            set
            {
                m_Open = value;
            }
        }

        public SaveFileDialog SaveFileDialog
        {
            get
            {
                return m_Save;
            }
            set
            {
                m_Save = value;
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
