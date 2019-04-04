using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Library.Application
{
    public interface ISomeRandomInterface
    {
        bool GiveMe(bool value);
        int GiveMe(int value);
        string GiveMe(string value);
    }
}
