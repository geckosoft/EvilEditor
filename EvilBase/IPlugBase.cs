using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvilBase
{
    public interface IPlugBase
    {
        string Author { get; }
        string Homepage { get; }
        string Description { get; }
        string LongDescription { get; }
        string Name { get; }
    }
}
