using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{
	public class MultisetUnsortedArray : Array
	{
		public MultisetUnsortedArray(){

		}

		public override bool Insert(int elem)
		{
			if (limit == array.Length) {
				Console.WriteLine ("Insert von " + elem + " fehlgeschlagen. Array ist voll!");
				return false;
			}

			if (elem < 1) {
				Console.WriteLine ("Nur positive Zahlen erlaubt!");
				return false;
			}

			array[limit] = elem;
			limit++;
			return true;

		}

		public override bool Search(int elem)
		{
			if (_Search(elem) >= 0)
			{
				return true;
			}

			return false;
		}

		private int _Search(int elem)
		{

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == elem)
				{
					return i;
				}
			}

			return -1;
		}

		public override bool Delete(int elem){
			return _Delete (_Search (elem));

		}


		/*public abstract bool Insert (int elem);
		public abstract bool Delete (int elem);

		public abstract bool Search (int elem);*/
	}
}
