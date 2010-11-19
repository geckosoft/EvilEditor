using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvilBase
{
    public interface IPlugTool : IPlugBase
    {
        void Unload();
        void Load(Form parentForm, ToolStripMenuItem toolsMenu);
    }
}
