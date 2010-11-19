using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvilBase
{
    public interface IPlugEditor : IPlugBase
    {
        IPlugFileType[] HandledFileTypes { get; }
        bool Enabled { get; set; }
        bool Opened { get; }
        void SaveFile(string filename);
        OpenFileDialog OpenFileDialog { get; set; }
        SaveFileDialog SaveFileDialog { get; set; }

        /// <summary>
        /// If this returns true, this means that only 1 editor per opened file can be open!
        /// 
        /// Example: When editing a save game, prevent the map editor to be opened.
        /// </summary>
        bool ExclusiveMode { get; }

        void Unload();
        void Load(Form parentForm, ToolStripMenuItem toolsMenu);
        void FileOpened(string filename);
    }
}
