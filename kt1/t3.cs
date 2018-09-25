using System;
using System.Collections.Generic;

namespace kt1 {
	class t3 {
		static void Main(){
			Console.WriteLine(reku(0));
			Console.WriteLine(reku(1));
			Console.WriteLine(reku(2));
			Console.WriteLine(reku(3));
			Console.WriteLine(reku(4));
			Console.WriteLine(reku(5));
		}
		static float reku(float x){
			if (x == 0) {
				return 1;
			} else {
				return ( 1 / (1 + reku(x-1)));
			}
		}
	}
}
