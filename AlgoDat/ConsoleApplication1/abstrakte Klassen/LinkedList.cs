using System;

namespace ConsoleApplication1
{
	public abstract class LinkedList : IDictionary
	{
		public class LinkedListNode {
			public LinkedListNode next = null;
			//public LinkedListNode prev = null;
			public int elem = 0;

			public LinkedListNode (int _elem) {
				elem = _elem;
			}
		}

		public LinkedListNode head = null;
		public LinkedListNode last = null;

		public LinkedList ()
		{
		}




		public abstract bool Insert (int elem);
		public abstract bool Delete(int elem);
		public abstract bool Search (int elem);

		public bool _Delete(LinkedListNode prevNode, LinkedListNode pointer){
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
			Console.WriteLine();
		}



	}

}

