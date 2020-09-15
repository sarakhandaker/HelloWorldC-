using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class HTTPCookie
    {
        public DateTime Expiry { get; set; }
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set { _dictionary[key] = value; }
        }
    }

}