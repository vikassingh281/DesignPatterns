using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib.Singleton
{
    public sealed class StringHelper
    {
        private static StringHelper _instance = null;

        public string Value { get; private set; }
        public static StringHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StringHelper();
                return _instance;
            }
        }

        private StringHelper() { }

        public void Append(string input)
        {
            if (!string.IsNullOrEmpty(Value))
                Value += " " + input;
            else
                Value += input;
        }
        public void Flush()
        {
            Value = string.Empty;
        }

    }
}
