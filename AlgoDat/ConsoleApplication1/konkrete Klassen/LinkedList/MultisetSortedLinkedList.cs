using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryFramework.konkrete_Klassen
{
	public class MultisetSortedLinkedList : LinkedList, IMultisetSorted
	{
		public MultisetSortedLinkedList ()
		{
		}

		public override bool Delete (int elem)
		{
			LinkedListNode[] result = _Search (elem);
			LinkedListNode prevNode = result [0];
			LinkedListNode pointer = result [1];
			if (result.Length == 3) {
				return _Delete (prevNode, pointer);
			} else {
				return false;
			}
		}

		public override bool Search (int elem)
		{
			LinkedListNode[] result = _Search (elem);
			if (result.Length == 3) {
				return true;
			} else {
				return false;
			}
		}

		protected LinkedListNode[] _Search(int elem){
			LinkedListNode pointer = head;
			LinkedListNode prevNode = null;

			while (pointer != null) {
				if (pointer.elem == elem) {
					return new LinkedListNode[]{prevNode, pointer, null};
				}
				if (pointer.elem > elem) {
					return new LinkedListNode[]{prevNode, pointer};
				}

				prevNode = pointer;
				pointer = pointer.next;
			}

			return new LinkedListNode[]{prevNode, pointer};


		}
		protected bool _Insert(int elem, LinkedListNode[] preSearchResult = null){

			LinkedListNode[] result = null;
			if (preSearchResult == null) {
				result = _Search (elem);
			} else {
				result = preSearchResult;
			}

			LinkedListNode prevNode = result [0];
			LinkedListNode pointer = result [1];

			LinkedListNode newNode = new LinkedListNode (elem);
			if (prevNode != null) {
				prevNode.next = newNode;
			} else {
				head = newNode;
			}
			newNode.next = pointer;
			if (pointer == null) {
				last = newNode;
			}

			return true;


		}

		public override bool Insert(int elem){
			return _Insert (elem);
		}

	}
}
