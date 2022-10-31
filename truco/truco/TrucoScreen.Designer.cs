/*
 * Created by SharpDevelop.
 * User: fabri
 * Date: 29/10/2022
 * Time: 18:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace truco
{
	partial class TrucoScreen
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Button accept;
		public System.Windows.Forms.Button upTruco;
		public System.Windows.Forms.Button runaway;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer delay;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrucoScreen));
			this.accept = new System.Windows.Forms.Button();
			this.upTruco = new System.Windows.Forms.Button();
			this.runaway = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.delay = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// accept
			// 
			this.accept.BackColor = System.Drawing.Color.LimeGreen;
			this.accept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accept.BackgroundImage")));
			this.accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.accept.Cursor = System.Windows.Forms.Cursors.Hand;
			this.accept.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.accept.ForeColor = System.Drawing.Color.Black;
			this.accept.Location = new System.Drawing.Point(319, 236);
			this.accept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.accept.Name = "accept";
			this.accept.Size = new System.Drawing.Size(80, 80);
			this.accept.TabIndex = 15;
			this.accept.UseVisualStyleBackColor = false;
			this.accept.Click += new System.EventHandler(this.AcceptClick);
			// 
			// upTruco
			// 
			this.upTruco.BackColor = System.Drawing.Color.Gold;
			this.upTruco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upTruco.BackgroundImage")));
			this.upTruco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.upTruco.Cursor = System.Windows.Forms.Cursors.Hand;
			this.upTruco.Font = new System.Drawing.Font("Arial", 14.2F, System.Drawing.FontStyle.Bold);
			this.upTruco.ForeColor = System.Drawing.Color.Black;
			this.upTruco.Location = new System.Drawing.Point(80, 236);
			this.upTruco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upTruco.Name = "upTruco";
			this.upTruco.Size = new System.Drawing.Size(80, 80);
			this.upTruco.TabIndex = 14;
			this.upTruco.UseVisualStyleBackColor = false;
			this.upTruco.Click += new System.EventHandler(this.UpTrucoClick);
			// 
			// runaway
			// 
			this.runaway.BackColor = System.Drawing.Color.SteelBlue;
			this.runaway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("runaway.BackgroundImage")));
			this.runaway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.runaway.Cursor = System.Windows.Forms.Cursors.Hand;
			this.runaway.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.runaway.ForeColor = System.Drawing.Color.Black;
			this.runaway.Location = new System.Drawing.Point(564, 236);
			this.runaway.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.runaway.Name = "runaway";
			this.runaway.Size = new System.Drawing.Size(80, 80);
			this.runaway.TabIndex = 13;
			this.runaway.UseVisualStyleBackColor = false;
			this.runaway.Click += new System.EventHandler(this.RunawayClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(690, 357);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(110, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "TRUCO!";
			// 
			// delay
			// 
			this.delay.Interval = 500;
			this.delay.Tick += new System.EventHandler(this.DelayTick);
			// 
			// TrucoScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(682, 353);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.accept);
			this.Controls.Add(this.upTruco);
			this.Controls.Add(this.runaway);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TrucoScreen";
			this.Text = "TrucoScreen";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrucoScreenFormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
