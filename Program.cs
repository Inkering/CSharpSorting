using System;

namespace CSharpSorting
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Random random = new Random();

			//Make a random list of unsorted values and list them
			int[] values = new int[10];
			Console.WriteLine("Unsorted:");
			for (int i = 0; i < values.Length; i++)
			{
				values[i] = random.Next(1, 100);
				Console.WriteLine(values[i]);
			}
			//Bubble Sorting
			int[] bubbled = Sort.bubble(values);
			Console.WriteLine("Bubble Sorted:");
			for (int i = 0; i < bubbled.Length; i++)
			{
				Console.WriteLine(bubbled[i]);
			}
			int[] selected = Sort.selection(values);
			Console.WriteLine("Selection Sorted:");
			for (int i = 0; i < selected.Length; i++)
			{
				Console.WriteLine(selected[i]);
			}
			//Insertion sorting
			int[] inserted = Sort.insertion(values);
			Console.WriteLine("Insertion Sorted:");
			for (int i = 0; i < inserted.Length; i++)
			{
				Console.WriteLine(bubbled[i]);
			}
			//keep the console open :P
			Console.ReadLine();
		}
	}
}