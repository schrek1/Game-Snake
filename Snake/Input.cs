using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake {
	class Input {
		//list klaves
		private static Hashtable keyTable=new Hashtable();

		//zjistuje zda je stisknuta zvlastni klavesa
		public static bool KeyPressed(Keys key) {
			if (keyTable[key]==null) {
				return false;
			}
			return (bool)keyTable[key];
		}

		//zjisteni drzeni klavesy
		public static void ChangeState(Keys key, bool state) {
			keyTable[key]=state;
		}
	}
}
