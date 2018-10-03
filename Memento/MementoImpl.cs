using System.Collections.Generic;

namespace Memento
{
    public class MementoImpl : Memento
    {
        protected IList<OptionVehicule> options = new List<OptionVehicule>();

        public IList<OptionVehicule> LesOptions
        {
            get
            {
                return options;
            }
            set
            {
                options.Clear();
                foreach (OptionVehicule option in value)
                    options.Add(option);
            }
        }
    }
}