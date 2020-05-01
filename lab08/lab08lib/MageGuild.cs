using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab08lib
{
    public partial class MageGuild : List<Mage>
    {
        public delegate void HiredMage(Mage mage);

        public delegate void FiredMage(Mage mage);

        public event HiredMage OnMageAdded;
        public event FiredMage OnMageRemoved;
        public void AddMage(Mage mage)
        {
            if (this.Any(x => x.Name.Equals(mage.Name)))
            {
                throw new MageExistException();
            }

            OnMageAdded?.Invoke(mage);

            this.Add(mage);
        }

        public void RemoveMage(string name)
        {

            var mage = this.FirstOrDefault(x => x.Name.Equals(name));
            if (mage == null)
            {
                throw new MageNotExistException();
            }
            OnMageRemoved?.Invoke(mage);
            this.Remove(mage);
        }
        public override string ToString()
        {
            string result = "";
            this.ForEach(s => result += s.ToString());
            return result;
        }

       



    }
}
