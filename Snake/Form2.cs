using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Snake {
	public partial class Form2 : Form {
		Form1 parent=null;
		private List<Square> Had= new List<Square>();
		private Square food = new Square();
		private bool pause=false;
		
	

		public Form2(Form1 parent) {
			InitializeComponent();
			this.parent=parent;
			lPauza.Visible=false;

			CheckFullScreen();

		}

		//fullscreen
		public void CheckFullScreen() {
			if (parent.checkBox1.Checked) {
				FormBorderStyle=FormBorderStyle.None;
				WindowState=FormWindowState.Maximized;
			} else {
				FormBorderStyle=FormBorderStyle.Sizable;
				WindowState=FormWindowState.Normal;
			}
		}

		//zachytava stisky, meni souradnice hada, aktualizuje canvas
		private void UpdateScreen(object sender, EventArgs e) {
			if (Settings.gameOver==true) {
				if (Input.KeyPressed(Keys.Enter)) {
					StartGame();
				}
			} else {
				if (Input.KeyPressed(Keys.Right)&&Settings.direction!=Direction.left)
					Settings.direction=Direction.right;
				else if (Input.KeyPressed(Keys.Left)&&Settings.direction!=Direction.right)
					Settings.direction=Direction.left;
				else if (Input.KeyPressed(Keys.Up)&&Settings.direction!=Direction.down)
					Settings.direction=Direction.up;
				else if (Input.KeyPressed(Keys.Down)&&Settings.direction!=Direction.up)
					Settings.direction=Direction.down;
				MovePlayer();
			}
			Canvas.Invalidate();
		}

		//uvodni nastaveni
		private void StartGame(){
			new Settings();
			Had.Clear();
			lgo.Visible=false;
			Square head = new Square();
			head.x=10;
			head.y=5;
			Had.Add(head);

			lscore.Text = Settings.score.ToString();
			GenerateFood();
		}

		private void GenerateFood() {
			int maxXPos=Canvas.Size.Width-Settings.width;
			int maxYPos=Canvas.Size.Height-Settings.height;

			Random rnd=new Random();
			food=new Square();
			food.x=rnd.Next(0, maxXPos);
			food.y=rnd.Next(0, maxYPos);
		}

		public void Tranform() {
			if (Settings.direction==Direction.left) {
				Had[0].x=Canvas.Size.Width/Settings.width;
			}
			if (Settings.direction==Direction.right) {
				Had[0].x=0;
			}
			if (Settings.direction==Direction.up) {
				Had[0].y=Canvas.Size.Height/Settings.width;
			}
			if (Settings.direction==Direction.down) {
				Had[0].y=0;
			}
		}


		private void MovePlayer() {
			for(int i = Had.Count - 1; i>=0; i--){
				if (i==0) {
					switch (Settings.direction) {
						case Direction.right:
							Had[i].x++;
							break;
						case Direction.left:
							Had[i].x--;
							break;
						case Direction.up:
							Had[i].y--;
							break;
						case Direction.down:
							Had[i].y++;
							break;
					}


					int maxXPos=Canvas.Size.Width/Settings.width;
					int maxYPos=Canvas.Size.Height/Settings.height;

					
					if (Had[i].x<0||Had[i].y<0||Had[i].x-1>=maxXPos||Had[i].y>=maxYPos) {
						if(parent.cBorder.Checked)
						Tranform(); //-> TODO procházení canvasem skrs na skrs
						else
						Die();
					}


					for (int j=1; j<Had.Count; j++) {
						if (Had[i].x==Had[j].x&&Had[i].y==Had[j].y) {
							Die();
						}
					}


					if (Math.Abs(Had[0].x*Settings.width-food.x)<8&&Math.Abs(Had[0].y*Settings.height-food.y)<15) {
						Eat();
					}
					if (Math.Abs(Had[0].x*Settings.width-food.x)<15&&Math.Abs(Had[0].y*Settings.height-food.y)<8) {
						Eat();
					}

				} else {
					Had[i].x=Had[i-1].x;
					Had[i].y=Had[i-1].y;
				}
			}
		}


		//nastaveni timeru
		private void Form2_Load(object sender, EventArgs e) {
			new Settings();
			gameTimer.Interval=1000/Settings.speed;
			gameTimer.Tick+=UpdateScreen;
			gameTimer.Start();
			StartGame();
		}

		private void Form2_Closing(object sender,System.ComponentModel.CancelEventArgs e) {
			
		}

		private void bEnd_Click(object sender, EventArgs e) {
			Snake.Menu.SoundButton();
			this.parent.Show();
			this.Close();
		}

		private void Canvas_Paint(object sender, PaintEventArgs e) {
			Graphics canvas=e.Graphics;
			if (Settings.gameOver==false) {
				Brush snakeColor;
				for(int i = 0; i<Had.Count; i++) {
					if (i==0) {
						snakeColor=Brushes.YellowGreen;
					} else {
						snakeColor=Brushes.Green;
					}
					label1.Text=food.x.ToString()+" "+food.y.ToString();
					label3.Text=(Had[0].x*Settings.width).ToString()+" "+(Had[0].y*Settings.height).ToString();
					canvas.FillRectangle(snakeColor, new Rectangle(Had[i].x*Settings.width, Had[i].y*Settings.height, Settings.width, Settings.height));
					canvas.FillRectangle(Brushes.Red, new Rectangle(food.x, food.y, Settings.width, Settings.height));
				}

			} else {
				lgo.Visible=true;
			}
		}

		private void Eat() {
			Snake.Menu.SoundEat();
			Square square=new Square {
				x=Had[Had.Count-1].x,
				y=Had[Had.Count-1].y
			};
			Had.Add(square);

			Settings.score+=Settings.points;
			lscore.Text=Settings.score.ToString();

			GenerateFood();
		}

		private void Die() {
			Snake.Menu.SoundGameOver();
			Settings.gameOver=true;
		}

		private void Form2_KeyDown_1(object sender, KeyEventArgs e) {
			Input.ChangeState(e.KeyCode, true);
		}

		private void Form2_KeyUp_1(object sender, KeyEventArgs e) {
			Input.ChangeState(e.KeyCode, false);
		}

		private void label5_Click(object sender, EventArgs e) {
			if (this.pause) {
				this.gameTimer.Enabled=true;
				this.gameTimer.Start();
				this.pause=false;
				this.lPauza.Visible=false;
			} else {
				this.gameTimer.Stop();
				this.gameTimer.Enabled=false;
				this.pause=true;
				this.lPauza.Visible=true;
			}
		}

		private void label6_Click(object sender, EventArgs e) {
			StartGame();
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e) {
			
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
		
		}

	}
}
