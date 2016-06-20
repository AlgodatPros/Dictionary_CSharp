using System;

namespace DictionaryFramework
{
	public abstract class LinkedList : IDictionary
	{
		protected class LinkedListNode {
			public LinkedListNode next = null;
			public int elem = 0;

			public LinkedListNode (int _elem) {
				elem = _elem;
			}
		}

		protected LinkedListNode head = null;
		protected LinkedListNode last = null;

		public LinkedList ()
		{
		}




		public abstract bool Insert (int elem);
		public abstract bool Delete(int elem);
		public abstract bool Search (int elem);

		protected bool _Delete(LinkedListNode prevNode, LinkedListNode pointer){
			if (pointer != null) {
				if (prevNode != null) {
					prevNode.next = pointer.next;
				} else {
					head = pointer.next;
				}

				if (last == pointer) {
					last = prevNode;
				}
				return true;
			}
			return false;
		}


		public void Print(){
			LinkedListNode pointer = head;
			while (pointer != null) {
				Console.Write (pointer.elem + " "); 
				pointer = pointer.next;
			}
				Console.WriteLine ();
		}

		public void SimplePrint(){
			LinkedListNode pointer = head;
			while (pointer != null) {
				Console.Write (pointer.elem.ToString().PadLeft(2) + " "); 
				pointer = pointer.next;
			}
		}

	}

}

