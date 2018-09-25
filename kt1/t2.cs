using System;
using System.Collections.Generic;

namespace kt1 {
	class t2 {
		static void Main(){
			Console.WriteLine(luku(0));			
			Console.WriteLine(luku(3));
			Console.WriteLine(luku(5));
		}
		static float luku(float x){
			return (fibo(x-1) / fibo(x));
		}

		static float fibo(float x) {
			if (x <= 0 || x == 1) return 1;
			else return (fibo(x-2) + fibo(x-1));
		}
	}
	
}
