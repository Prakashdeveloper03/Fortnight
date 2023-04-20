using System;
using System.Collections.Generic;

class Solution {
	static void Main(string[] args) {
		Dictionary<string, int> map = new Dictionary<string, int>();
		int n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; i++) {
			string[] input = Console.ReadLine().Split();
			string name = input[0];
			int phone = int.Parse(input[1]);
			map.Add(name, phone);
		}
		while (Console.ReadLine() is string s) {
			if (map.TryGetValue(s, out int phone)) {
				Console.WriteLine($"{s}={phone}");
			} else {
				Console.WriteLine("Not found");
			}
		}
	}
}