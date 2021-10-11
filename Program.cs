using search_word;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic

{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList sortedList = new SortedList();
			sortedList.Add(1990, "Phyton");
			sortedList.Add(2001, "C#");
			sortedList.Add(1978, "SQL");
			sortedList.Add(1972, "C");
			sortedList.Add(1995, "JavaScript");

			foreach (DictionaryEntry num in sortedList)
			{
				Console.WriteLine(num.Key);

			}
			foreach (DictionaryEntry item in sortedList)
			{
				Console.WriteLine(item.Value);
			}
		}
	}
}










