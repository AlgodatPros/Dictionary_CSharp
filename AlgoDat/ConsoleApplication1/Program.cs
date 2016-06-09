using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace für konkrete Klassen
using ConsoleApplication1.konkrete_Klassen;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            
			IDictionary[] dictionaries =  {
				new BinTree(),

				new AVLTree(),

				new MultisetSortedLinkedList(),
				new SetSortedLinkedList(),
				new MultisetUnsortedLinkedList(),
				new SetUnsortedLinkedList(),
				new MultisetSortedArray(),
				new MultisetUnsortedArray(),
				new SetSortedArray(),
				new SetUnsortedArray(),
				new HashTabSepChain(),
                new HashTabQuadProb()
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



            Console.WriteLine("Wählen Sie aus was sie machen wollen: ");
            Console.WriteLine(" 1: Tree ");
            Console.WriteLine(" 2: Array");
            Console.WriteLine(" 3: LinkedList");
            Console.WriteLine(" 4: Hash");
            int ersteAuswahl = Convert.ToInt32(Console.ReadLine());

            int zweiteAuswahl = 0;
            switch (ersteAuswahl)
            {
                case 1:
                    Console.WriteLine("Welchen Tree wollen sie benutzen: (0) BinTree oder (1) AVLTree");
                    zweiteAuswahl = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Welches Array wollen sie benutzen: (6) MultiSetSorted , (7) MuliSetUnsorted , (8) SetSorted , (9) SetUnsorted");
                    zweiteAuswahl = Convert.ToInt32(Console.ReadLine());

                    break;
                case 3:
                    Console.WriteLine("Welche Linked List wollen sie benutzen: (2) MultiSetSorted  , (3) SetSorted, (4) MuliSetUnsorted, (5) SetUnsorted");
                    zweiteAuswahl = Convert.ToInt32(Console.ReadLine());

                    break;
                case 4:
                    Console.WriteLine("Welchen Hash wollen sie benutzen: (10) SepChain oder (11) QuadProb");
                    zweiteAuswahl = Convert.ToInt32(Console.ReadLine());

                    break;
            }

            bool abbrechen = false;
            while (!abbrechen)
            {
                Console.WriteLine("welche methode wollen sie ausführen: (1) Insert , (2) Delete, (3) Search, (4) Print ");
                int dritteAuswahl = Convert.ToInt32(Console.ReadLine());
                int elem;
                Console.WriteLine();
                switch (dritteAuswahl)
                {
                    case 1:
                        
                        Console.WriteLine("welche Zahl?");
                        elem = Convert.ToInt32(Console.ReadLine());
                        dictionaries[zweiteAuswahl].Insert(elem);
                        Console.WriteLine();
                        dictionaries[zweiteAuswahl].Print();
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.WriteLine("welche Zahl?");
                        elem = Convert.ToInt32(Console.ReadLine());
                        dictionaries[zweiteAuswahl].Delete(elem);
                        Console.WriteLine();
                        dictionaries[zweiteAuswahl].Print();
                        Console.WriteLine();

                        break;
                    case 3:
                        Console.WriteLine("welche Zahl?");
                        elem = Convert.ToInt32(Console.ReadLine());
                        dictionaries[zweiteAuswahl].Search(elem);
                        Console.WriteLine();
                        dictionaries[zweiteAuswahl].Print();
                        Console.WriteLine();

                        break;
                    case 4:
                        dictionaries[zweiteAuswahl].Print();
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine("Wollen sie forfahren? Y / N");
                Console.WriteLine();
                string forfahren = Convert.ToString(Console.ReadLine());

                if (forfahren == "n")
                {
                    abbrechen = true;
                }

            }


			/*IDictionary btree = new BinTree (); //91951
			int[] insertarr = {6,3,2,4,9,8,10,1,5};
			for (int i = 0; i < insertarr.Length; i++) {
				btree.Insert(insertarr[i]);
				btree.Print();
			}
			Random a = new Random();
			int n = a.Next(1,10);
			Console.WriteLine("=== Delete " + n + " ===");
			btree.Delete(3);
			btree.Print();*/ 
            //for (int d = 0; d < dictionaries.Length; d++) {
            //    Console.WriteLine ();
            //    Console.WriteLine ("----- Dictionary: " + dictionaries_name[d] + " -----");
            //    Random a = new Random();
            //    Random b = new Random (65465465);
            //    for (int i = 0; i < 10; i++)
            //    {
            //        int n = a.Next(1,20);
            //        //Console.WriteLine("=== Insert " + n + " ===");
            //        dictionaries[d].Insert(n);
            //        dictionaries[d].Print();
            //        if (n % 2 == 0) {

            //            int k = b.Next (1, 10);
            //            //Console.WriteLine ("Search " + k + ": " + dictionaries [d].Search (n));
            //            //Console.WriteLine("=== Delete " + k + " ===");
            //            //dictionaries[d].Print();
            //            dictionaries[d].Delete(k);
            //            dictionaries[d].Print();
            //            //Console.WriteLine ("Search " + k + ": " + dictionaries [d].Search (k));
            //        }
            //    }


            //}







        }
    }

}
