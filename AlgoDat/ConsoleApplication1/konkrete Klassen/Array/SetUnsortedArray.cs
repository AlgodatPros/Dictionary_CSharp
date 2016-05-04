using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{

    class SetUnsortedArray : MultisetUnsortedArray
    {
		public override bool Insert (int elem){
			if (!Search (elem)) {
				return base.Insert (elem);
			} else {
				return false;
			}
		}

    }
}
