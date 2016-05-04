using System;

namespace ConsoleApplication1
{
	public abstract class SortedLinkedList : LinkedList
	{
		public SortedLinkedList ()
		{
		}

		public override bool Delete (int elem)
		{
			LinkedListNode[] result = _Search (elem);
			LinkedListNode prevNode = result [0];
			LinkedListNode pointer = result [1];
			return _Delete (prevNode, pointer);
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

		public LinkedListNode[] _Search(int elem){
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

		public override bool Insert(int elem){
			LinkedListNode[] result = _Search (elem);
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

	}
}

