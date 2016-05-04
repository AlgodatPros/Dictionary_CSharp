using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace für konrete Klassen
using ConsoleApplication1.konkrete_Klassen;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

           /* Console.WriteLine("Suche");
			int search_elem = 12;//Convert.ToInt32(Console.ReadLine());

            IDictionary mua = new MultisetUnsortedArray();
            IDictionary sua = new SetUnsortedArray();
            IDictionary mss = new MultisetSortedArray();
            mua.Insert(7);
            mua.Insert(12);
            mua.Insert(34);
            mua.Insert(67);
            mua.Insert(75);
            mua.Print();
            mua.Delete(67);


            mua.Print();

            Console.WriteLine(mua.Search(search_elem));

            sua.Insert(12);
            sua.Insert(45);
            sua.Insert(35);
            sua.Insert(567);
            sua.Insert(1);
            sua.Insert(45);
            sua.Print();
            sua.Delete(45);
            sua.Print();

            Console.WriteLine(sua.Search(search_elem));
            Random a = new Random();
            for (int i = 0; i < 20; i++)
            {
                int n = a.Next(1,100);
                Console.WriteLine("=== Insert " + n + " ===");
                mss.Insert(n);
				mss.Print();
            }
            

            mss.Print();


            Console.ReadKey();*/
			IDictionary[] dictionaries =  {
				new MultisetSortedLinkedList(),
				new SetSortedLinkedList(),
				new MultisetUnsortedLinkedList(),
				new SetUnsortedLinkedList(),
				new MultisetSortedArray(),
				new MultisetUnsortedArray(),
				new SetSortedArray(),
				new SetUnsortedArray()
			};

			string[] dictionaries_name =  {
				"MultisetSortedLinkedList",
				"SetSortedLinkedList",
				"MultisetUnsortedLinkedList",
				"SetUnsortedLinkedList",
				"MultisetSortedArray",
				"MultisetUnsortedArray",
				"SetSortedArray",
				"SetUnsortedArray"
			};

			/*IDictionary ssa = new SetSortedArray (); //91951
			int[] insertarr = {9,1,9,5,1};
			for (int i = 0; i < insertarr.Length; i++) {
				ssa.Insert(insertarr[i]);
				ssa.Print();
			}*/

			for (int d = 0; d < dictionaries.Length; d++) {
				Console.WriteLine ();
				Console.WriteLine ("----- Dictionary: " + dictionaries_name[d] + " -----");
				Random a = new Random();
				for (int i = 0; i < 5; i++)
				{
					int n = a.Next(1,10);
					Console.WriteLine("=== Insert " + n + " ===");
					dictionaries[d].Insert(n);
					dictionaries[d].Print();
					if (n % 2 == 0) {
						Console.WriteLine("=== Search " + n + " ===");
						Console.WriteLine (dictionaries [d].Search (n));
						//Console.WriteLine("=== Delete " + n + " ===");
						//dictionaries[d].Delete(n);
						//dictionaries[d].Print();
						//Console.WriteLine("=== Search " + n + " ===");
						//Console.WriteLine (dictionaries [d].Search (n));
					}
				}
			}







        }
    }

}
