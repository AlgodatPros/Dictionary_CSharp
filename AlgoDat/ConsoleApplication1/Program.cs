using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace für konkrete Klassen
using DictionaryFramework.konkrete_Klassen;

namespace DictionaryFramework
{
    class Program
    {
        static void Main(string[] args)
        {
			//Demo ();
			IDictionary[] dictionaries =  {
				Dictionary.Create (SortedSet.BinTree), //oder Dictionary.Create(Set.BinTree)
				Dictionary.Create (SortedSet.AVLTree),
				Dictionary.Create (SortedMultiset.LinkedList),
				Dictionary.Create (SortedSet.LinkedList),
				Dictionary.Create (UnsortedMultiset.LinkedList),
				Dictionary.Create (UnsortedSet.LinkedList),
				Dictionary.Create (SortedMultiset.Array),
				Dictionary.Create (UnsortedMultiset.Array),
				Dictionary.Create (SortedSet.Array),
				Dictionary.Create (UnsortedSet.Array),
				Dictionary.Create (UnsortedMultiset.HashTabSepChain),
				Dictionary.Create (UnsortedMultiset.HashTabQuadProb),
			};

		Nochmal:
			Console.WriteLine("Wählen Sie aus was sie machen wollen: ");
			Console.WriteLine(" 1: Tree ");
			Console.WriteLine(" 2: Array");
			Console.WriteLine(" 3: LinkedList");
			Console.WriteLine(" 4: Hash");
			Console.WriteLine(" 99: Demo");

			int ersteAuswahl = Convert.ToInt32(Console.ReadLine());

			switch (ersteAuswahl)
			{
			case 1:
				Console.WriteLine("Welchen Tree wollen sie benutzen: (0) BinTree oder (1) AVLTree");
			break;
			case 2:
				Console.WriteLine("Welches Array wollen sie benutzen: (6) MultiSetSorted, (7) MuliSetUnsorted, (8) SetSorted, (9) SetUnsorted");
			break;
			case 3:
				Console.WriteLine("Welche Linked List wollen sie benutzen: (2) MultiSetSorted, (3) SetSorted, (4) MuliSetUnsorted, (5) SetUnsorted");
			break;
			case 4:
				Console.WriteLine("Welchen Hash wollen sie benutzen: (10) SepChain oder (11) QuadProb");
			break;
			case 99:
				Demo ();
				System.Environment.Exit (0);
			break;
			default:
				goto Nochmal;
			}

			int zweiteAuswahl = Convert.ToInt32(Console.ReadLine());

			bool abbrechen = false;
			while (!abbrechen)
			{
				Console.WriteLine("welche methode wollen sie ausführen: (1) Insert, (2) Delete, (3) Search, (4) Print ");
				int dritteAuswahl = Convert.ToInt32(Console.ReadLine());
				if (dritteAuswahl < 4) {
					Console.WriteLine();
					Console.WriteLine("Welche Zahl?");
					int elem = Convert.ToInt32(Console.ReadLine());

					switch (dritteAuswahl)
					{
					case 1:                
						dictionaries[zweiteAuswahl].Insert(elem);
						break;
					case 2:
						dictionaries[zweiteAuswahl].Delete(elem);
						break;
					case 3:
						dictionaries[zweiteAuswahl].Search(elem);
						break;
					default:
						continue;
					}

				}
				if(dritteAuswahl > 4) {
					continue;
				}
				Console.WriteLine();
				dictionaries[zweiteAuswahl].Print();
				Console.WriteLine();

				Console.WriteLine("Wollen sie forfahren? Y / N");
				Console.WriteLine();
				string forfahren = Convert.ToString(Console.ReadLine());

				if (forfahren == "n")
				{
					abbrechen = true;
				}

			}



        }

		static void Demo(){
			//Beispiele:
			/*ISet[] dictSet = {
				(ISet) Dictionary.Create (Set.AVLTree),
				(ISet) Dictionary.Create(UnsortedSet.LinkedList)
			};

			ISet[] genSets = {
				GDictionary<ISet>.Create(Set.AVLTree),
				GDictionary<ISet>.Create(UnsortedSet.LinkedList)
			};*/

			IDictionary[] dictionaries =  {
				Dictionary.Create (SortedSet.BinTree), //oder Dictionary.Create(Set.BinTree)
				Dictionary.Create (SortedSet.AVLTree),
				Dictionary.Create (SortedMultiset.LinkedList),
				Dictionary.Create (SortedSet.LinkedList),
				Dictionary.Create (UnsortedMultiset.LinkedList),
				Dictionary.Create (UnsortedSet.LinkedList),
				Dictionary.Create (SortedMultiset.Array),
				Dictionary.Create (UnsortedMultiset.Array),
				Dictionary.Create (SortedSet.Array),
				Dictionary.Create (UnsortedSet.Array),
				Dictionary.Create (UnsortedMultiset.HashTabSepChain),
				Dictionary.Create (UnsortedMultiset.HashTabQuadProb),
			};

			string[] dictionaries_name =  {
				"BinTree",
				"AVLTree",
				"MultisetSortedLinkedList",
				"SetSortedLinkedList",
				"MultisetUnsortedLinkedList",
				"SetUnsortedLinkedList",
				"MultisetSortedArray",
				"MultisetUnsortedArray",
				"SetSortedArray",
				"SetUnsortedArray",
				"HashTabSepChain", 
				"HashTabQuadProb"
			};


			for (int d = 0; d < dictionaries.Length; d++) {
				Console.WriteLine ();
				Console.WriteLine ("----- Dictionary: " + dictionaries_name[d] + " -----");
				Random a = new Random();
				Random b = new Random (65465465);
				for (int i = 0; i < 30; i++)
				{
					int n = a.Next(1,20);
					//Console.WriteLine("=== Insert " + n + " ===");
					dictionaries[d].Insert(n);
					dictionaries[d].Print();
					if (n % 2 == 0) {

						int k = b.Next (1, 10);

						/*Console.WriteLine ("Search " + k + ": " + dictionaries [d].Search (k));
						Console.WriteLine("=== Delete " + k + " ===");*/
					
						dictionaries[d].Delete(k);
						dictionaries[d].Print();

					}
				}
			}


    	}
	}
}
