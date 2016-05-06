using System;

namespace ConsoleApplication1
{
	public abstract class Array : IDictionary
	{
		public int[] array = new int[20];
		public int limit = 0;

		public Array ()
		{
		}

		public void Print()
		{
			for (int i = 0; i < array.Length && array[i] != 0; i++)
			{
				Console.Write(array[i] + " " );
			}
			Console.WriteLine();
		}

		public abstract bool Insert (int elem);
		public abstract bool Delete(int elem);

		public bool _Delete(int index)
		{
			//int index = _Search(elem);
			if (index >= 0)
			{
				array[index] = 0;
				for (int i = index; i < array.Length - 1; i++)
				{
					array[i] = array[i + 1];
				}
				limit--;
				return true;

			}
			else
				return false;
		}

		public abstract bool Search (int elem);
	}
}

