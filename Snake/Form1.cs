using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Snake {
	public partial class Form1 : Form {
		public bool music=false;
		public static bool effect=true;
		public static int slider=16;

		public Form1() {
			InitializeComponent();
			boxPlayers.Visible=false;
			boxRanking.Visible=false;
			boxSettings.Visible=false;
			Snake.Menu.PlayMusic(this);
			if (effect) {
				checkEffect.Checked=true;
			}
		}

		private void bOne_Click(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
			Form2 gameForm=new Form2(this);
			this.Visible=false;
			gameForm.Show();

		}

		private void label1_Click(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
			Snake.Menu.RemoveBoxes(this);
			boxPlayers.Visible=true;
		}

		private void bEnd_Click(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
			Application.Exit();
		}

		private void bRankings_Click(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
			Snake.Menu.RemoveBoxes(this);
			boxRanking.Visible=true;
		}

		private void groupBox1_Enter(object sender, EventArgs e) {

		}

		private void bSettings_Click(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
			Snake.Menu.RemoveBoxes(this);
			boxSettings.Visible=true;
			if (music) {
				checkMusic.Checked=true;
			} else {
				checkMusic.Checked=false;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
			if (checkMusic.Checked) {
				music=true;
			} else {
				music=false;
			}
			Snake.Menu.PlayMusic(this);
		}

		private void checkEffect_CheckedChanged(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
			if (checkEffect.Checked) {
				effect=true;
			} else {
				effect=false;
			}
		}

		private void bTwo_Click(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
		}

		private void label1_Click_1(object sender, EventArgs e) {

		}

		private void trackBar1_ValueChanged(object sender, EventArgs e) {
			Snake.Form1.slider=trackBar1.Value;
			label5.Text=Snake.Form1.slider.ToString();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit(); //velmi dulezita funkce ve sparvci uloh pak aplikace visi 
		}

		private void checkBox1_CheckedChanged_1(object sender, EventArgs e) {
			if (this.checkBox1.Checked) {
				FormBorderStyle=FormBorderStyle.None;
				WindowState=FormWindowState.Maximized;
			} else {
				FormBorderStyle=FormBorderStyle.Sizable;
				WindowState=FormWindowState.Normal;
			}
		}
	}
}
