using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryFramework.konkrete_Klassen
{
	public class MultisetSortedArray : Array, IMultisetSorted
	{


		public MultisetSortedArray ()
		{
		}


		public override bool Delete(int elem){
			return _Delete (_Search(elem));
		}

		protected bool _Insert(int elem, int preSearchIndex = -1){
			if (limit == array.Length) {
				Console.WriteLine ("Insert von " + elem + " fehlgeschlagen. Array ist voll!");
				return false;
			}

			if (elem < 1) {
				Console.WriteLine ("Nur positive Zahlen erlaubt!");
				return false;
			}

			if (limit == 0)
			{
				array[0] = elem;
			}
			else
			{
				int index = -1;
				if (preSearchIndex < 0) {
					index = _Search (elem); //oder _Search (elem, 0, limit - 1);

					if (index < 0) {
						index = -(index + 1);
					}

				} else {
					index = preSearchIndex;
				}

				if (array [index] != 0) {
					//Verschiebe die Elemente eins nach rechts um Platz für das neue Element zu machen
					//Array.Copy (array, index, array, index + 1, limit-index);
					for (int i = limit; i > index; i--) {
						array [i] = array [i-1];
					}
				}
				array [index] = elem;
			}
			limit++;

			return true;
		}
		public override bool Insert(int elem)
		{
			return _Insert (elem);
		}

		public override bool Search (int elem){
			bool isDuplicate = false;
			_Search(elem, ref isDuplicate);
			return isDuplicate;
		}

		protected int _Search(int elem){
			bool tmp = false;
			return _Search (elem, ref tmp);
		}

		protected int _Search(int elem, ref bool isDuplicate){
			int result = _Search(elem, 0, limit-1);
			if (result < 0) {
				isDuplicate = true;
			}
			result = -(result + 1);
			return result;
		}

		protected int _Search(int elem, int left, int right)
		{
			if (left <= right)
			{
				int middle = (left + right) / 2;
				if (elem == array [middle])
					return -middle-1; //negativ für Duplikaterkennung und Erkennung wenn Duplikat bei Index=0
				else if (elem < array [middle])
					return _Search (elem, left, middle - 1);
				else
					return _Search (elem, middle + 1, right);
			}
			return left;
		}
	}
}
