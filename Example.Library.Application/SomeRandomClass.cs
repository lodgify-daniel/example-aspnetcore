using System;

namespace Example.Library.Application
{
    public class SomeRandomClass : ISomeRandomInterface
    {
        public bool GiveMe(bool value) => value;

        public int GiveMe(int value) => value;

        public string GiveMe(string value) => value;
    }
}
