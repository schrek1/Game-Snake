using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake {

	//pomocne metody pro Formy
	public class Menu {
		public static SoundPlayer sndPlayer=new SoundPlayer(Snake.Properties.Resources.jungle);
		public static SoundPlayer sndButton=new SoundPlayer(Snake.Properties.Resources.button);
		public static SoundPlayer sndEat=new SoundPlayer(Snake.Properties.Resources.eat);
		public static SoundPlayer sndOver=new SoundPlayer(Snake.Properties.Resources.over);

		public static void RemoveBoxes(Form1 f){
			f.boxPlayers.Visible=false;
			f.boxRanking.Visible=false;
			f.boxSettings.Visible=false;
		}

		public static void PlayMusic(Form1 f) {
			if (f.music) {
				sndPlayer.PlayLooping();
			} else {
				sndPlayer.Stop();
			}
		}

		public static void SoundButton() {
			if (Snake.Form1.effect) {
				sndButton.Play();
			}
		}

		public static void SoundEat() {
			if (Snake.Form1.effect) {
				sndEat.Play();
			}
		}

		public static void SoundGameOver() {
			if (Snake.Form1.effect) {
				sndOver.Play();
			}
		}

		

	}
}
