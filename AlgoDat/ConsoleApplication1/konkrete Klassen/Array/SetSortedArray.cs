using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{
    class SetSortedArray : MultisetSortedArray
    {

		public override bool Insert (int elem){
			int result = _Search(elem, 0, limit-1);
			if (result > -1) {
				return _Insert (elem,-(result+1));
			} else {
				return false;
			}
		}

    }
}
