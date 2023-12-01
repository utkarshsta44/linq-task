using System;
using System.Linq;
using System.Collections.Generic;

public class question1

{
	public static void Method()
	{
		IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
		IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };

		var result1 = strList.Skip(2);
		var result2 = intList.SkipWhile(s => s < 2);

		foreach (var res in result1)
			Console.WriteLine(res);

		foreach (var res in result2)
			Console.WriteLine(res);

	}
}