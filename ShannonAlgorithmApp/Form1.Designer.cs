
namespace ShannonAlgorithmApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.codePage = new System.Windows.Forms.TabPage();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.decodePage = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.codePage.SuspendLayout();
			this.decodePage.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.codePage);
			this.tabControl1.Controls.Add(this.decodePage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 468);
			this.tabControl1.TabIndex = 5;
			// 
			// codePage
			// 
			this.codePage.Controls.Add(this.richTextBox2);
			this.codePage.Controls.Add(this.button1);
			this.codePage.Controls.Add(this.richTextBox1);
			this.codePage.Location = new System.Drawing.Point(4, 24);
			this.codePage.Name = "codePage";
			this.codePage.Padding = new System.Windows.Forms.Padding(3);
			this.codePage.Size = new System.Drawing.Size(792, 440);
			this.codePage.TabIndex = 0;
			this.codePage.Text = "To code";
			this.codePage.UseVisualStyleBackColor = true;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(8, 270);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richTextBox2.Size = new System.Drawing.Size(776, 164);
			this.richTextBox2.TabIndex = 5;
			this.richTextBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(8, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 56);
			this.button1.TabIndex = 4;
			this.button1.Text = "To code";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 6);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(776, 164);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// decodePage
			// 
			this.decodePage.Controls.Add(this.button2);
			this.decodePage.Controls.Add(this.richTextBox4);
			this.decodePage.Controls.Add(this.richTextBox3);
			this.decodePage.Location = new System.Drawing.Point(4, 24);
			this.decodePage.Name = "decodePage";
			this.decodePage.Padding = new System.Windows.Forms.Padding(3);
			this.decodePage.Size = new System.Drawing.Size(792, 440);
			this.decodePage.TabIndex = 1;
			this.decodePage.Text = "To decode";
			this.decodePage.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.button2.Location = new System.Drawing.Point(8, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(182, 56);
			this.button2.TabIndex = 2;
			this.button2.Text = "To decode";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// richTextBox4
			// 
			this.richTextBox4.Location = new System.Drawing.Point(8, 270);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(776, 164);
			this.richTextBox4.TabIndex = 1;
			this.richTextBox4.Text = "";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(8, 6);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(776, 164);
			this.richTextBox3.TabIndex = 0;
			this.richTextBox3.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 492);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Text analyzer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.codePage.ResumeLayout(false);
			this.decodePage.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage codePage;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TabPage decodePage;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.RichTextBox richTextBox3;
	}
}

