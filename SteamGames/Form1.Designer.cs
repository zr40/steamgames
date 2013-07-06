namespace SteamGames
{
	internal partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Button button1;
			System.Windows.Forms.Button button4;
			System.Windows.Forms.Button button2;
			System.Windows.Forms.Button button3;
			BrightIdeasSoftware.OLVColumn olvColumn1;
			System.Windows.Forms.Panel panel2;
			System.Windows.Forms.Panel panel3;
			this.panel1 = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.FilterList = new System.Windows.Forms.ListBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
			button1 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			panel2 = new System.Windows.Forms.Panel();
			panel3 = new System.Windows.Forms.Panel();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			button1.ForeColor = System.Drawing.Color.White;
			button1.Location = new System.Drawing.Point(3, 46);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(109, 37);
			button1.TabIndex = 1;
			button1.Text = "Run game";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			button4.AutoSize = true;
			button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flowLayoutPanel2.SetFlowBreak(button4, true);
			button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			button4.Location = new System.Drawing.Point(118, 46);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(161, 37);
			button4.TabIndex = 2;
			button4.Text = "Community Hub";
			button4.UseVisualStyleBackColor = true;
			button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.ForeColor = System.Drawing.Color.White;
			button2.Location = new System.Drawing.Point(3, 281);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 4;
			button2.Text = "Delete";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.ForeColor = System.Drawing.Color.White;
			button3.Location = new System.Drawing.Point(204, 281);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(75, 23);
			button3.TabIndex = 6;
			button3.Text = "Add";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// olvColumn1
			// 
			olvColumn1.AspectName = "Name";
			olvColumn1.CellPadding = null;
			// 
			// panel2
			// 
			panel2.Controls.Add(this.panel1);
			panel2.Controls.Add(panel3);
			panel2.Dock = System.Windows.Forms.DockStyle.Left;
			panel2.Location = new System.Drawing.Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(200, 914);
			panel2.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 703);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.AutoSize = true;
			panel3.Controls.Add(this.button7);
			panel3.Controls.Add(this.button6);
			panel3.Controls.Add(this.button5);
			panel3.Controls.Add(this.label2);
			panel3.Controls.Add(this.FilterList);
			panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			panel3.Location = new System.Drawing.Point(0, 703);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(200, 211);
			panel3.TabIndex = 0;
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Location = new System.Drawing.Point(146, 185);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(51, 23);
			this.button7.TabIndex = 10;
			this.button7.Text = "Delete";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new System.Drawing.Point(73, 185);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(46, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = "Edit";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(3, 185);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(42, 23);
			this.button5.TabIndex = 8;
			this.button5.Text = "Add";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Show:";
			// 
			// FilterList
			// 
			this.FilterList.BackColor = System.Drawing.Color.Black;
			this.FilterList.ForeColor = System.Drawing.Color.White;
			this.FilterList.FormattingEnabled = true;
			this.FilterList.Location = new System.Drawing.Point(3, 19);
			this.FilterList.Name = "FilterList";
			this.FilterList.Size = new System.Drawing.Size(194, 160);
			this.FilterList.TabIndex = 11;
			this.FilterList.SelectedIndexChanged += new System.EventHandler(this.FilterList_SelectedIndexChanged);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.label1);
			this.flowLayoutPanel2.Controls.Add(button1);
			this.flowLayoutPanel2.Controls.Add(button4);
			this.flowLayoutPanel2.Controls.Add(this.listBox1);
			this.flowLayoutPanel2.Controls.Add(button2);
			this.flowLayoutPanel2.Controls.Add(this.textBox1);
			this.flowLayoutPanel2.Controls.Add(button3);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(1378, 0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(282, 914);
			this.flowLayoutPanel2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.flowLayoutPanel2.SetFlowBreak(this.label1, true);
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 40);
			this.label1.TabIndex = 0;
			this.label1.UseMnemonic = false;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.BackColor = System.Drawing.Color.Black;
			this.flowLayoutPanel2.SetFlowBreak(this.listBox1, true);
			this.listBox1.ForeColor = System.Drawing.Color.White;
			this.listBox1.Location = new System.Drawing.Point(3, 89);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(277, 186);
			this.listBox1.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.Color.Black;
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(84, 281);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(114, 22);
			this.textBox1.TabIndex = 5;
			// 
			// objectListView1
			// 
			this.objectListView1.AllColumns.Add(olvColumn1);
			this.objectListView1.BackColor = System.Drawing.Color.Black;
			this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            olvColumn1});
			this.objectListView1.CopySelectionOnControlC = false;
			this.objectListView1.CopySelectionOnControlCUsesDragSource = false;
			this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.objectListView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.objectListView1.ForeColor = System.Drawing.Color.White;
			this.objectListView1.Location = new System.Drawing.Point(200, 0);
			this.objectListView1.MultiSelect = false;
			this.objectListView1.Name = "objectListView1";
			this.objectListView1.OwnerDraw = true;
			this.objectListView1.ShowGroups = false;
			this.objectListView1.ShowHeaderInAllViews = false;
			this.objectListView1.ShowImagesOnSubItems = true;
			this.objectListView1.Size = new System.Drawing.Size(1178, 914);
			this.objectListView1.TabIndex = 0;
			this.objectListView1.TileSize = new System.Drawing.Size(188, 99);
			this.objectListView1.UseCompatibleStateImageBehavior = false;
			this.objectListView1.View = System.Windows.Forms.View.Tile;
			this.objectListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.objectListView1_ItemSelectionChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1660, 914);
			this.Controls.Add(this.objectListView1);
			this.Controls.Add(panel2);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Steam Games";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
		private BrightIdeasSoftware.ObjectListView objectListView1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox FilterList;
	}
}

