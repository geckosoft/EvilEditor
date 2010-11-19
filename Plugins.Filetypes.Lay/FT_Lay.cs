using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilBase;

namespace EvilPlug.Filetypes.Lay
{
    public class FT_Lay : IPlugFileType
    {
        #region IPlugFileType Members

        public string Extension
        {
            get { return "lay"; }
        }

        public string ExtDescription
        {
            get { return "Map or savegame"; }
        }

        public string LongExtDescription
        {
            get { return "A map or a savegame."; }
        }

        public string Filter
        {
            get { return "*.lay"; }
        }

        #endregion

        #region IPlugBase Members

        public string Author
        {
            get { throw new NotImplementedException(); }
        }

        public string Homepage
        {
            get { throw new NotImplementedException(); }
        }

        public string Description
        {
            get { throw new NotImplementedException(); }
        }

        public string LongDescription
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
