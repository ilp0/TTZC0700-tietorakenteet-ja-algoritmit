using System;
using System.Collections.Generic;

namespace kt1 {
	class t5 {
		static void Main(){
			Console.WriteLine(juuri(1, 1f));
			Console.WriteLine(juuri(7, 1f));
			Console.WriteLine(juuri(30, 0.5f));
			Console.WriteLine(juuri(40, 1f));
			Console.WriteLine(juuri(50, 1f));
			Console.WriteLine(juuri(100, 1f));
		}
		static float juuri(float x, float tol){
			float old_x = 1;
			float new_x = x;
			while((Math.Abs(old_x - new_x)) > tol) {
				old_x = new_x;
				new_x = ((old_x+(x/old_x)) / 2);
				
			}

			return new_x;
			
		}
	}
}
