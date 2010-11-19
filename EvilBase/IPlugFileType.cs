using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvilBase
{
    public interface IPlugFileType : IPlugBase
    {
        string Extension { get; }
        string ExtDescription { get; }
        string LongExtDescription { get; }
        string Filter { get; }
    }
}
