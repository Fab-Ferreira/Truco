namespace truco
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button start;
		public System.Windows.Forms.PictureBox pointsV1;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox pointsD3;
		public System.Windows.Forms.PictureBox pointsD2;
		public System.Windows.Forms.PictureBox pointsD1;
		public System.Windows.Forms.PictureBox pointsV3;
		public System.Windows.Forms.PictureBox pointsV2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label labelD;
		public System.Windows.Forms.Label labelV;
		public System.Windows.Forms.Button truco;
		public System.Windows.Forms.Timer delayTruco;
		public System.Windows.Forms.PictureBox pbTitle;
		private System.Windows.Forms.Timer animation;
		private System.Windows.Forms.Timer iniciar;
		public System.Windows.Forms.Label valorPontos;
		public System.Windows.Forms.Button tutorialBtn;
		private System.Windows.Forms.Button credits;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label program;
		private System.Windows.Forms.Label design;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.start = new System.Windows.Forms.Button();
			this.pointsV1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.valorPontos = new System.Windows.Forms.Label();
			this.labelD = new System.Windows.Forms.Label();
			this.labelV = new System.Windows.Forms.Label();
			this.pointsD3 = new System.Windows.Forms.PictureBox();
			this.pointsD2 = new System.Windows.Forms.PictureBox();
			this.pointsD1 = new System.Windows.Forms.PictureBox();
			this.pointsV3 = new System.Windows.Forms.PictureBox();
			this.pointsV2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.truco = new System.Windows.Forms.Button();
			this.delayTruco = new System.Windows.Forms.Timer(this.components);
			this.pbTitle = new System.Windows.Forms.PictureBox();
			this.animation = new System.Windows.Forms.Timer(this.components);
			this.iniciar = new System.Windows.Forms.Timer(this.components);
			this.tutorialBtn = new System.Windows.Forms.Button();
			this.credits = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.program = new System.Windows.Forms.Label();
			this.design = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pointsV1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pointsD3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsD2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsD1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsV3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsV2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// start
			// 
			this.start.BackColor = System.Drawing.Color.Gainsboro;
			this.start.Cursor = System.Windows.Forms.Cursors.Hand;
			this.start.Enabled = false;
			this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.start.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.start.ForeColor = System.Drawing.Color.Black;
			this.start.Location = new System.Drawing.Point(549, 220);
			this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(400, 80);
			this.start.TabIndex = 0;
			this.start.Text = "INICIAR";
			this.start.UseVisualStyleBackColor = false;
			this.start.Visible = false;
			this.start.Click += new System.EventHandler(this.StartClick);
			// 
			// pointsV1
			// 
			this.pointsV1.BackColor = System.Drawing.Color.Transparent;
			this.pointsV1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pointsV1.Location = new System.Drawing.Point(150, 4);
			this.pointsV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pointsV1.Name = "pointsV1";
			this.pointsV1.Size = new System.Drawing.Size(40, 37);
			this.pointsV1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pointsV1.TabIndex = 2;
			this.pointsV1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.valorPontos);
			this.panel1.Controls.Add(this.labelD);
			this.panel1.Controls.Add(this.labelV);
			this.panel1.Controls.Add(this.pointsD3);
			this.panel1.Controls.Add(this.pointsD2);
			this.panel1.Controls.Add(this.pointsD1);
			this.panel1.Controls.Add(this.pointsV3);
			this.panel1.Controls.Add(this.pointsV2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pointsV1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 124);
			this.panel1.TabIndex = 3;
			this.panel1.Visible = false;
			// 
			// valorPontos
			// 
			this.valorPontos.Font = new System.Drawing.Font("Arial", 15.2F);
			this.valorPontos.ForeColor = System.Drawing.Color.LimeGreen;
			this.valorPontos.Location = new System.Drawing.Point(375, 41);
			this.valorPontos.Name = "valorPontos";
			this.valorPontos.Size = new System.Drawing.Size(83, 34);
			this.valorPontos.TabIndex = 10;
			this.valorPontos.Text = "+1";
			this.valorPontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelD
			// 
			this.labelD.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelD.ForeColor = System.Drawing.Color.White;
			this.labelD.Location = new System.Drawing.Point(323, 69);
			this.labelD.Name = "labelD";
			this.labelD.Size = new System.Drawing.Size(67, 34);
			this.labelD.TabIndex = 9;
			this.labelD.Text = "0";
			// 
			// labelV
			// 
			this.labelV.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelV.ForeColor = System.Drawing.Color.White;
			this.labelV.Location = new System.Drawing.Point(323, 7);
			this.labelV.Name = "labelV";
			this.labelV.Size = new System.Drawing.Size(77, 34);
			this.labelV.TabIndex = 2;
			this.labelV.Text = "0";
			// 
			// pointsD3
			// 
			this.pointsD3.BackColor = System.Drawing.Color.Transparent;
			this.pointsD3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pointsD3.Location = new System.Drawing.Point(240, 66);
			this.pointsD3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pointsD3.Name = "pointsD3";
			this.pointsD3.Size = new System.Drawing.Size(40, 37);
			this.pointsD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pointsD3.TabIndex = 7;
			this.pointsD3.TabStop = false;
			// 
			// pointsD2
			// 
			this.pointsD2.BackColor = System.Drawing.Color.Transparent;
			this.pointsD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pointsD2.Location = new System.Drawing.Point(195, 66);
			this.pointsD2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pointsD2.Name = "pointsD2";
			this.pointsD2.Size = new System.Drawing.Size(40, 37);
			this.pointsD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pointsD2.TabIndex = 6;
			this.pointsD2.TabStop = false;
			// 
			// pointsD1
			// 
			this.pointsD1.BackColor = System.Drawing.Color.Transparent;
			this.pointsD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pointsD1.Location = new System.Drawing.Point(148, 66);
			this.pointsD1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pointsD1.Name = "pointsD1";
			this.pointsD1.Size = new System.Drawing.Size(40, 37);
			this.pointsD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pointsD1.TabIndex = 5;
			this.pointsD1.TabStop = false;
			// 
			// pointsV3
			// 
			this.pointsV3.BackColor = System.Drawing.Color.Transparent;
			this.pointsV3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pointsV3.Location = new System.Drawing.Point(240, 4);
			this.pointsV3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pointsV3.Name = "pointsV3";
			this.pointsV3.Size = new System.Drawing.Size(40, 37);
			this.pointsV3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pointsV3.TabIndex = 4;
			this.pointsV3.TabStop = false;
			// 
			// pointsV2
			// 
			this.pointsV2.BackColor = System.Drawing.Color.Transparent;
			this.pointsV2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pointsV2.Location = new System.Drawing.Point(195, 4);
			this.pointsV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pointsV2.Name = "pointsV2";
			this.pointsV2.Size = new System.Drawing.Size(40, 37);
			this.pointsV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pointsV2.TabIndex = 3;
			this.pointsV2.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 34);
			this.label2.TabIndex = 1;
			this.label2.Text = "Eles:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vocês:";
			// 
			// truco
			// 
			this.truco.AutoSize = true;
			this.truco.BackColor = System.Drawing.Color.Gainsboro;
			this.truco.Cursor = System.Windows.Forms.Cursors.Hand;
			this.truco.Enabled = false;
			this.truco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.truco.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.truco.ForeColor = System.Drawing.Color.Black;
			this.truco.Location = new System.Drawing.Point(12, 250);
			this.truco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.truco.Name = "truco";
			this.truco.Size = new System.Drawing.Size(200, 57);
			this.truco.TabIndex = 9;
			this.truco.Text = "TRUCO";
			this.truco.UseVisualStyleBackColor = false;
			this.truco.Visible = false;
			this.truco.Click += new System.EventHandler(this.TrucoClick);
			// 
			// delayTruco
			// 
			this.delayTruco.Interval = 1000;
			this.delayTruco.Tick += new System.EventHandler(this.DelayTrucoTick);
			// 
			// pbTitle
			// 
			this.pbTitle.BackColor = System.Drawing.Color.Transparent;
			this.pbTitle.Location = new System.Drawing.Point(583, 118);
			this.pbTitle.Margin = new System.Windows.Forms.Padding(4);
			this.pbTitle.Name = "pbTitle";
			this.pbTitle.Size = new System.Drawing.Size(133, 62);
			this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbTitle.TabIndex = 13;
			this.pbTitle.TabStop = false;
			// 
			// animation
			// 
			this.animation.Interval = 1;
			this.animation.Tick += new System.EventHandler(this.AnimationTick);
			// 
			// iniciar
			// 
			this.iniciar.Interval = 1000;
			this.iniciar.Tick += new System.EventHandler(this.IniciarTick);
			// 
			// tutorialBtn
			// 
			this.tutorialBtn.AutoSize = true;
			this.tutorialBtn.BackColor = System.Drawing.Color.Gainsboro;
			this.tutorialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tutorialBtn.Enabled = false;
			this.tutorialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tutorialBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tutorialBtn.ForeColor = System.Drawing.Color.Black;
			this.tutorialBtn.Location = new System.Drawing.Point(12, 311);
			this.tutorialBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tutorialBtn.Name = "tutorialBtn";
			this.tutorialBtn.Size = new System.Drawing.Size(200, 57);
			this.tutorialBtn.TabIndex = 14;
			this.tutorialBtn.Text = "TUTORIAL";
			this.tutorialBtn.UseVisualStyleBackColor = false;
			this.tutorialBtn.Visible = false;
			this.tutorialBtn.Click += new System.EventHandler(this.TutorialBtnClick);
			// 
			// credits
			// 
			this.credits.BackColor = System.Drawing.Color.Gainsboro;
			this.credits.Cursor = System.Windows.Forms.Cursors.Hand;
			this.credits.Enabled = false;
			this.credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.credits.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.credits.ForeColor = System.Drawing.Color.Black;
			this.credits.Location = new System.Drawing.Point(549, 388);
			this.credits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.credits.Name = "credits";
			this.credits.Size = new System.Drawing.Size(400, 80);
			this.credits.TabIndex = 15;
			this.credits.Text = "CRÉDITOS";
			this.credits.UseVisualStyleBackColor = false;
			this.credits.Visible = false;
			this.credits.Click += new System.EventHandler(this.CreditsClick);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Gainsboro;
			this.back.Cursor = System.Windows.Forms.Cursors.Hand;
			this.back.Enabled = false;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.Color.Black;
			this.back.Location = new System.Drawing.Point(549, 304);
			this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(400, 80);
			this.back.TabIndex = 16;
			this.back.Text = "VOLTAR";
			this.back.UseVisualStyleBackColor = false;
			this.back.Visible = false;
			this.back.Click += new System.EventHandler(this.BackClick);
			// 
			// program
			// 
			this.program.AutoSize = true;
			this.program.BackColor = System.Drawing.Color.Transparent;
			this.program.ForeColor = System.Drawing.Color.White;
			this.program.Location = new System.Drawing.Point(294, 183);
			this.program.Name = "program";
			this.program.Size = new System.Drawing.Size(287, 17);
			this.program.TabIndex = 17;
			this.program.Text = "Programação de: Fabrício Prudente Ferreira";
			this.program.Visible = false;
			// 
			// design
			// 
			this.design.AutoSize = true;
			this.design.BackColor = System.Drawing.Color.Transparent;
			this.design.ForeColor = System.Drawing.Color.White;
			this.design.Location = new System.Drawing.Point(294, 212);
			this.design.Name = "design";
			this.design.Size = new System.Drawing.Size(210, 17);
			this.design.TabIndex = 18;
			this.design.Text = "Design de: Alicia Reis Marcolino";
			this.design.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(961, 479);
			this.Controls.Add(this.design);
			this.Controls.Add(this.program);
			this.Controls.Add(this.back);
			this.Controls.Add(this.credits);
			this.Controls.Add(this.tutorialBtn);
			this.Controls.Add(this.pbTitle);
			this.Controls.Add(this.truco);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.start);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Truco";
			((System.ComponentModel.ISupportInitialize)(this.pointsV1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pointsD3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsD2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsD1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsV3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pointsV2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
