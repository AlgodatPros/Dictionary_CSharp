using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryFramework.konkrete_Klassen
{
    class SetSortedArray : MultisetSortedArray, ISetSorted
    {

		public override bool Insert (int elem){
			bool isDuplicate = false;
			int result = _Search(elem, ref isDuplicate);
			if (isDuplicate) {
				return false;
			} else {
				return _Insert (elem, result);
			}
		}

    }
}
