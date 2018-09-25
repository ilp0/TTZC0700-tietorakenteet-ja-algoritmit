using System;
using System.Collections.Generic;

namespace kt1 {
	class t1 {
		static void Main(){
			List<int> a = new List<int>();
			a = luvut(13);
			foreach (int x in a){
				Console.WriteLine(x);
			}
		}
		static List<int> luvut(int x){
			int k = 0;
			List<int> a = new List<int>();
			a.Add(1);
			while (a[k] <= x) {
				k++;
				a.Add(a[k-1] + a[k-1]);
			}
			return a;
		}
	}
	
}
