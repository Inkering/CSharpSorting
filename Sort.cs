using System;
namespace CSharpSorting
{
	public class Sort
	{
		//By Erik Boeson
		public int[] bubble(int[] array)
		{
			//loop through the array until sorted
			for (int i = 0; i < array.Length; i++)
			{
				//loop through the array once
				for (int j = 1; j < array.Length; j++)
				{
					//is the first value of two larger?
					//if so, move it up
					if (array[j - 1] > array[j])
					{
						//store second value and replace it with the first
						int temp = array[j];
						array[j] = array[j - 1];
						//make first value the second value
						array[j - 1] = temp;
					}
				}
			}
			return array;
		}
		//By Erik Boeson
		public int[] selection(int[] array)
		{
			for (int i = array.Length - 1; i > 0; i--)
			{
				int high = array[0];
				int index = 0;

				for (int j = 0; j < i; j++)
				{
					if (array[j] > high)
					{
						high = array[j];
						index = j;
					}
				}
			}
			return array;
		}
		//Written by Dieter Brehm
		public int[] insertion(int[] array)
		{
			//Loop through the array until sorted
			for (int i = 1; i < array.Length; i++)
			{
				int index = array[i];
				int j = i;
				//The two conditions of the insertion sort.
				//imcrement then decrement
				while ((j > 0) && (array[j - 1] > index))
				{
					array[j] = array[j - 1];
					j = j - 1;
				}
				array[j] = index;
			}
			return array;
		}
	}
}

