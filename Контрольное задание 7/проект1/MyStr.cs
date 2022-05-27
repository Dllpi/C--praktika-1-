using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace space

{
    internal class MyStr
    {
        public String(int len)
        {
            length = len;
            str = new StringBuilder(length);
        }
        public String(string s, int len)
        {
            length = len;
            str = new StringBuilder(s.Substring(0, length));
        }
        public int CountSpaces()
        {
            return str.ToString().Count(x => x == ' ');
        }
        public void RemovePuncts()
        {
            string s = str.ToString();
            str.Clear();
            str.Append(Regex.Replace(s, "[,.:?!]", ""));
            length = str.Length;
        }
        public int Length
        {
            get { return length; }
        }
        public override string ToString()
        {
            return str.ToString();
        }
        private StringBuilder str;
        private int length;
    }
}
