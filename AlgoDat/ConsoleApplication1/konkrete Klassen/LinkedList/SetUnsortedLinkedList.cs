using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryFramework.konkrete_Klassen
{
	class SetUnsortedLinkedList : MultisetUnsortedLinkedList, ISetUnsorted
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
