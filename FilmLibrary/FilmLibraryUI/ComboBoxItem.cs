using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryUI
{
    public  class ComboBoxItem<T>
    {
        public string DisplayMember = "";
        public T ValueMember = default(T);

        public override string ToString()
        {
            return DisplayMember;
        }

    }
}
