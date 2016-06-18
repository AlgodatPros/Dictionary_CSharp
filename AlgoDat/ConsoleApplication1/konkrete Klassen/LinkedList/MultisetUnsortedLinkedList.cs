using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryFramework.konkrete_Klassen
{
	public class MultisetUnsortedLinkedList : LinkedList, IMultisetUnsorted
	{
		public MultisetUnsortedLinkedList ()
		{
		}

		public override bool Search(int elem){
			if (_Search (elem).Length == 3) {
				return true;
			}
			return false;
		}

		protected LinkedListNode[] _Search(int elem){
			LinkedListNode pointer = head;
			LinkedListNode prevNode = null;

			while (pointer != null) {
				if (pointer.elem == elem) {
					return new LinkedListNode[]{prevNode, pointer, null};
				}

				prevNode = pointer;
				pointer = pointer.next;
			}

			return new LinkedListNode[]{null, null};
		}

		public override bool Delete (int elem)
		{
			LinkedListNode[] result = _Search (elem);
			LinkedListNode prevNode = result [0];
			LinkedListNode pointer = result [1];
			return _Delete (prevNode, pointer);
		}

		public override bool Insert(int elem){

			LinkedListNode newNode = new LinkedListNode (elem);
			if (head == null) {
				head = newNode;
				last = head;
			} else {
				last.next = newNode;
				last = newNode;
			}
			return true;
		}


	}
}
