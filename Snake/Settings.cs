using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
	//vlastni nastaveni hry
	public enum Direction {
		up,
		down,
		right,
		left
	};

	class Settings {
		public static int width {
			get;
			set;
		}
		public static int height {
			get;
			set;
		}
		public static int speed {
			get;
			set;
		}
		public static int score {
			get;
			set;
		}
		public static int points {
			get;
			set;
		}
		public static bool gameOver {
			get;
			set;
		}
		public static Direction direction {
			get;
			set;
		}

		public Settings() {
			width=16;
			height=16;
			speed=Snake.Form1.slider;
			score=0;
			points=6*Snake.Form1.slider; // pro vetsi chalenge :)
			gameOver=false;
			direction=Direction.down;
		}
	}
}
