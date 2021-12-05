using System;

namespace DualTimers {
	class Program {
		static void Main () {
			Console.WriteLine ("== Dual Timers");

			new Timing ().Start ();

			Console.ResetColor ();
			Console.WriteLine ("== End");
		}
	}
}
