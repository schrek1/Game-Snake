namespace Snake {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components=null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label4 = new System.Windows.Forms.Label();
			this.bEnd = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lscore = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Canvas = new System.Windows.Forms.PictureBox();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.lgo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lPauza = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(620, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ondřej Schrek 2015";
			// 
			// bEnd
			// 
			this.bEnd.AutoSize = true;
			this.bEnd.BackColor = System.Drawing.Color.Green;
			this.bEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.bEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bEnd.Location = new System.Drawing.Point(32, 337);
			this.bEnd.Name = "bEnd";
			this.bEnd.Size = new System.Drawing.Size(131, 26);
			this.bEnd.TabIndex = 10;
			this.bEnd.Text = "Zpět do menu";
			this.bEnd.Click += new System.EventHandler(this.bEnd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.OliveDrab;
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lscore);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.bEnd);
			this.groupBox1.Location = new System.Drawing.Point(523, 55);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 385);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			// 
			// lscore
			// 
			this.lscore.AutoSize = true;
			this.lscore.BackColor = System.Drawing.Color.Snow;
			this.lscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lscore.ForeColor = System.Drawing.Color.Red;
			this.lscore.Location = new System.Drawing.Point(125, 42);
			this.lscore.Name = "lscore";
			this.lscore.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lscore.Size = new System.Drawing.Size(20, 24);
			this.lscore.TabIndex = 12;
			this.lscore.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Red;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(59, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "Score";
			// 
			// Canvas
			// 
			this.Canvas.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.Canvas.Location = new System.Drawing.Point(12, 55);
			this.Canvas.Name = "Canvas";
			this.Canvas.Size = new System.Drawing.Size(505, 385);
			this.Canvas.TabIndex = 12;
			this.Canvas.TabStop = false;
			this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
			// 
			// lgo
			// 
			this.lgo.AutoSize = true;
			this.lgo.BackColor = System.Drawing.Color.Red;
			this.lgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lgo.ForeColor = System.Drawing.Color.White;
			this.lgo.Location = new System.Drawing.Point(142, 218);
			this.lgo.Name = "lgo";
			this.lgo.Size = new System.Drawing.Size(259, 37);
			this.lgo.TabIndex = 13;
			this.lgo.Text = " GAME OVER!!!";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "label1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "label3";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Green;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label5.Location = new System.Drawing.Point(65, 300);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(64, 26);
			this.label5.TabIndex = 13;
			this.label5.Text = "Pauza";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Green;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label6.Location = new System.Drawing.Point(63, 261);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 26);
			this.label6.TabIndex = 14;
			this.label6.Text = "Restart";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// lPauza
			// 
			this.lPauza.AutoSize = true;
			this.lPauza.BackColor = System.Drawing.Color.Green;
			this.lPauza.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lPauza.ForeColor = System.Drawing.Color.White;
			this.lPauza.Location = new System.Drawing.Point(206, 218);
			this.lPauza.Name = "lPauza";
			this.lPauza.Size = new System.Drawing.Size(130, 37);
			this.lPauza.TabIndex = 16;
			this.lPauza.Text = "PAUZA";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Snake.Properties.Resources.assas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(735, 470);
			this.ControlBox = false;
			this.Controls.Add(this.lPauza);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lgo);
			this.Controls.Add(this.Canvas);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Had";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
			this.Load += new System.EventHandler(this.Form2_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown_1);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp_1);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label bEnd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox Canvas;
		private System.Windows.Forms.Label lscore;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Label lgo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lPauza;
	}
}