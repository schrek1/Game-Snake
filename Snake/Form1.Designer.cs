namespace Snake {
	partial class Form1 {
		/// <summary>
		/// Vyžadovaná proměnná návrháře.
		/// </summary>
		private System.ComponentModel.IContainer components=null;

		/// <summary>
		/// Uvolnit všechny používané prostředky.
		/// </summary>
		/// <param name="disposing">hodnota true, když by měl být spravovaný prostředek odstraněn, jinak false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kód generovaný Návrhářem Windows Form

		/// <summary>
		/// Metoda vyžadovaná pro podporu návrháře - neupravovat
		/// obsah této metody v editoru kódu.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bOne = new System.Windows.Forms.Button();
			this.bTwo = new System.Windows.Forms.Button();
			this.bNew = new System.Windows.Forms.Label();
			this.boxPlayers = new System.Windows.Forms.GroupBox();
			this.bEnd = new System.Windows.Forms.Label();
			this.bRankings = new System.Windows.Forms.Label();
			this.bSettings = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.boxRanking = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.boxSettings = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.checkEffect = new System.Windows.Forms.CheckBox();
			this.checkMusic = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cBorder = new System.Windows.Forms.CheckBox();
			this.boxPlayers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.boxRanking.SuspendLayout();
			this.boxSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// bOne
			// 
			this.bOne.BackColor = System.Drawing.Color.Silver;
			this.bOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bOne.ForeColor = System.Drawing.Color.Silver;
			this.bOne.Location = new System.Drawing.Point(6, 19);
			this.bOne.Name = "bOne";
			this.bOne.Size = new System.Drawing.Size(169, 23);
			this.bOne.TabIndex = 0;
			this.bOne.Text = "1 hráč";
			this.bOne.UseVisualStyleBackColor = false;
			this.bOne.Click += new System.EventHandler(this.bOne_Click);
			// 
			// bTwo
			// 
			this.bTwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.bTwo.Location = new System.Drawing.Point(6, 48);
			this.bTwo.Name = "bTwo";
			this.bTwo.Size = new System.Drawing.Size(169, 23);
			this.bTwo.TabIndex = 0;
			this.bTwo.Text = "2 hráči";
			this.bTwo.UseVisualStyleBackColor = true;
			this.bTwo.Click += new System.EventHandler(this.bTwo_Click);
			// 
			// bNew
			// 
			this.bNew.AutoSize = true;
			this.bNew.BackColor = System.Drawing.Color.Green;
			this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.bNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bNew.Location = new System.Drawing.Point(64, 147);
			this.bNew.Name = "bNew";
			this.bNew.Size = new System.Drawing.Size(86, 24);
			this.bNew.TabIndex = 1;
			this.bNew.Text = "Nová hra";
			this.bNew.Click += new System.EventHandler(this.label1_Click);
			// 
			// boxPlayers
			// 
			this.boxPlayers.BackColor = System.Drawing.Color.Green;
			this.boxPlayers.Controls.Add(this.bOne);
			this.boxPlayers.Controls.Add(this.bTwo);
			this.boxPlayers.ForeColor = System.Drawing.Color.White;
			this.boxPlayers.Location = new System.Drawing.Point(164, 147);
			this.boxPlayers.Name = "boxPlayers";
			this.boxPlayers.Size = new System.Drawing.Size(187, 78);
			this.boxPlayers.TabIndex = 2;
			this.boxPlayers.TabStop = false;
			this.boxPlayers.Text = "Počet hráčů";
			// 
			// bEnd
			// 
			this.bEnd.AutoSize = true;
			this.bEnd.BackColor = System.Drawing.Color.Green;
			this.bEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.bEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bEnd.Location = new System.Drawing.Point(64, 277);
			this.bEnd.Name = "bEnd";
			this.bEnd.Size = new System.Drawing.Size(65, 24);
			this.bEnd.TabIndex = 3;
			this.bEnd.Text = "Konec";
			this.bEnd.Click += new System.EventHandler(this.bEnd_Click);
			// 
			// bRankings
			// 
			this.bRankings.AutoSize = true;
			this.bRankings.BackColor = System.Drawing.Color.Green;
			this.bRankings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.bRankings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bRankings.Location = new System.Drawing.Point(64, 192);
			this.bRankings.Name = "bRankings";
			this.bRankings.Size = new System.Drawing.Size(85, 24);
			this.bRankings.TabIndex = 4;
			this.bRankings.Text = "Žebříček";
			this.bRankings.Click += new System.EventHandler(this.bRankings_Click);
			// 
			// bSettings
			// 
			this.bSettings.AutoSize = true;
			this.bSettings.BackColor = System.Drawing.Color.Green;
			this.bSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.bSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bSettings.Location = new System.Drawing.Point(64, 235);
			this.bSettings.Name = "bSettings";
			this.bSettings.Size = new System.Drawing.Size(92, 24);
			this.bSettings.TabIndex = 5;
			this.bSettings.Text = "Nastavení";
			this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 69);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(272, 264);
			this.dataGridView1.TabIndex = 6;
			// 
			// boxRanking
			// 
			this.boxRanking.BackColor = System.Drawing.Color.Green;
			this.boxRanking.Controls.Add(this.label3);
			this.boxRanking.Controls.Add(this.dataGridView1);
			this.boxRanking.ForeColor = System.Drawing.Color.White;
			this.boxRanking.Location = new System.Drawing.Point(165, 63);
			this.boxRanking.Name = "boxRanking";
			this.boxRanking.Size = new System.Drawing.Size(284, 346);
			this.boxRanking.TabIndex = 3;
			this.boxRanking.TabStop = false;
			this.boxRanking.Text = "Žebříček";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Green;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label3.Location = new System.Drawing.Point(6, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Nejlepší hráči";
			// 
			// boxSettings
			// 
			this.boxSettings.BackColor = System.Drawing.Color.Green;
			this.boxSettings.Controls.Add(this.cBorder);
			this.boxSettings.Controls.Add(this.label6);
			this.boxSettings.Controls.Add(this.checkBox1);
			this.boxSettings.Controls.Add(this.label5);
			this.boxSettings.Controls.Add(this.trackBar1);
			this.boxSettings.Controls.Add(this.checkEffect);
			this.boxSettings.Controls.Add(this.checkMusic);
			this.boxSettings.Controls.Add(this.label2);
			this.boxSettings.Controls.Add(this.label1);
			this.boxSettings.ForeColor = System.Drawing.Color.White;
			this.boxSettings.Location = new System.Drawing.Point(171, 96);
			this.boxSettings.Name = "boxSettings";
			this.boxSettings.Size = new System.Drawing.Size(309, 227);
			this.boxSettings.TabIndex = 7;
			this.boxSettings.TabStop = false;
			this.boxSettings.Text = "Nastavení";
			this.boxSettings.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Green;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label6.Location = new System.Drawing.Point(149, 106);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 24);
			this.label6.TabIndex = 13;
			this.label6.Text = "Obrazovka";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(164, 146);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(71, 17);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.Text = "fullscreen";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(116, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(19, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "16";
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Location = new System.Drawing.Point(6, 58);
			this.trackBar1.Maximum = 32;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(104, 45);
			this.trackBar1.TabIndex = 10;
			this.trackBar1.Value = 16;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// checkEffect
			// 
			this.checkEffect.AutoSize = true;
			this.checkEffect.Location = new System.Drawing.Point(23, 180);
			this.checkEffect.Name = "checkEffect";
			this.checkEffect.Size = new System.Drawing.Size(55, 17);
			this.checkEffect.TabIndex = 9;
			this.checkEffect.Text = "efekty";
			this.checkEffect.UseVisualStyleBackColor = true;
			this.checkEffect.CheckedChanged += new System.EventHandler(this.checkEffect_CheckedChanged);
			// 
			// checkMusic
			// 
			this.checkMusic.AutoSize = true;
			this.checkMusic.Location = new System.Drawing.Point(23, 148);
			this.checkMusic.Name = "checkMusic";
			this.checkMusic.Size = new System.Drawing.Size(56, 17);
			this.checkMusic.TabIndex = 8;
			this.checkMusic.Text = "hudba";
			this.checkMusic.UseVisualStyleBackColor = true;
			this.checkMusic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Green;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label2.Location = new System.Drawing.Point(6, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Zvuky";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Green;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label1.Location = new System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Rychlost hada";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(620, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ondřej Schrek 2015";
			// 
			// cBorder
			// 
			this.cBorder.AutoSize = true;
			this.cBorder.Location = new System.Drawing.Point(160, 58);
			this.cBorder.Name = "cBorder";
			this.cBorder.Size = new System.Drawing.Size(118, 17);
			this.cBorder.TabIndex = 14;
			this.cBorder.Text = "pruchozi ohraniceni";
			this.cBorder.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Snake.Properties.Resources.assas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(735, 470);
			this.Controls.Add(this.boxSettings);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bSettings);
			this.Controls.Add(this.bRankings);
			this.Controls.Add(this.bEnd);
			this.Controls.Add(this.bNew);
			this.Controls.Add(this.boxPlayers);
			this.Controls.Add(this.boxRanking);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Had";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.boxPlayers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.boxRanking.ResumeLayout(false);
			this.boxRanking.PerformLayout();
			this.boxSettings.ResumeLayout(false);
			this.boxSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bOne;
		private System.Windows.Forms.Button bTwo;
		private System.Windows.Forms.Label bNew;
		private System.Windows.Forms.Label bEnd;
		private System.Windows.Forms.Label bRankings;
		private System.Windows.Forms.Label bSettings;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.GroupBox boxPlayers;
		public System.Windows.Forms.GroupBox boxRanking;
		public System.Windows.Forms.GroupBox boxSettings;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkEffect;
		private System.Windows.Forms.CheckBox checkMusic;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.CheckBox checkBox1;
		public System.Windows.Forms.CheckBox cBorder;
	}
}

