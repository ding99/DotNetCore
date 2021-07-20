using System;
using System.Timers;

namespace DualTimers {
	public class Timing {

		public void Start() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Timing Class");

			Timer timer1 = new Timer(5000);
			timer1.Elapsed += ONTimer1;
			timer1.AutoReset = true;
			timer1.Enabled = true;

			Timer timer2 = new Timer(3000);
			timer2.Elapsed += OnTimer2;
			timer2.AutoReset = true;
			timer2.Enabled = true;

			Console.WriteLine("Press Enter key to stop the timer service");
			Console.ReadLine();

			timer1.Stop();
			timer1.Dispose();

			timer2.Stop();
			timer2.Dispose();
		}

		private void ONTimer1(object source, ElapsedEventArgs e) {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Timer 1: " + e.SignalTime);
		}

		private void OnTimer2(object source, ElapsedEventArgs e) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Timer 2: " + e.SignalTime);
		}
	}
}
