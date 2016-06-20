using System;

namespace DictionaryFramework
{
	public abstract class Array : IDictionary
	{
		protected int[] array = new int[20];
		protected int limit = 0;

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

		protected bool _Delete(int index)
		{
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

