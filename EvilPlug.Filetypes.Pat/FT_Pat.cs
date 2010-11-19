using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilBase;

namespace EvilPlug.Filetypes.Pat
{
    public class FT_Pat : IPlugFileType
    {
        #region IPlugFileType Members

        public string Extension
        {
            get { return "pat"; }
        }

        public string ExtDescription
        {
            get { return "Pattern"; }
        }

        public string LongExtDescription
        {
            get { return "A Pattern."; }
        }

        public string Filter
        {
            get { return "*.pat"; }
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
