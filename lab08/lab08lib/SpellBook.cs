using System;
using System.Collections.Generic;
using System.Text;

namespace lab08lib
{
    public class SpellBook : List<Spell>
    {
        public override string ToString()
        {
            string result = "";
            this.ForEach(s => result += s.ToString());
            return result;
        }
    }
}
