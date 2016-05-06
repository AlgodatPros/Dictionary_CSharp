using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{
    class SetSortedLinkedList : MultisetSortedLinkedList
    {
		public override bool Insert (int elem){
			LinkedListNode [] result = _Search (elem);
			if (result.Length < 3) {
				return _Insert (elem, result);
			} else {
				return false;
			}
		}
    }
}
