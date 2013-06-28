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
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
			this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 964);
			this.panel1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.label1);
			this.flowLayoutPanel2.Controls.Add(this.button1);
			this.flowLayoutPanel2.Controls.Add(this.listBox1);
			this.flowLayoutPanel2.Controls.Add(this.button2);
			this.flowLayoutPanel2.Controls.Add(this.textBox1);
			this.flowLayoutPanel2.Controls.Add(this.button3);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(1383, 0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(277, 964);
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
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flowLayoutPanel2.SetFlowBreak(this.button1, true);
			this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(3, 46);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "Run game";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.Black;
			this.flowLayoutPanel2.SetFlowBreak(this.listBox1, true);
			this.listBox1.ForeColor = System.Drawing.Color.White;
			this.listBox1.Location = new System.Drawing.Point(3, 89);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(274, 186);
			this.listBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(3, 281);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Black;
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(84, 281);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(107, 22);
			this.textBox1.TabIndex = 5;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(197, 281);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// objectListView1
			// 
			this.objectListView1.AllColumns.Add(this.olvColumn1);
			this.objectListView1.BackColor = System.Drawing.Color.Black;
			this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
			this.objectListView1.CopySelectionOnControlC = false;
			this.objectListView1.CopySelectionOnControlCUsesDragSource = false;
			this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.objectListView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.objectListView1.ForeColor = System.Drawing.Color.White;
			this.objectListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.objectListView1.HideSelection = false;
			this.objectListView1.Location = new System.Drawing.Point(200, 0);
			this.objectListView1.MultiSelect = false;
			this.objectListView1.Name = "objectListView1";
			this.objectListView1.OwnerDraw = true;
			this.objectListView1.SelectAllOnControlA = false;
			this.objectListView1.SelectColumnsMenuStaysOpen = false;
			this.objectListView1.SelectColumnsOnRightClick = false;
			this.objectListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.objectListView1.ShowFilterMenuOnRightClick = false;
			this.objectListView1.ShowGroups = false;
			this.objectListView1.ShowHeaderInAllViews = false;
			this.objectListView1.ShowImagesOnSubItems = true;
			this.objectListView1.ShowSortIndicators = false;
			this.objectListView1.Size = new System.Drawing.Size(1183, 964);
			this.objectListView1.TabIndex = 4;
			this.objectListView1.TileSize = new System.Drawing.Size(188, 99);
			this.objectListView1.UseCompatibleStateImageBehavior = false;
			this.objectListView1.UseOverlays = false;
			this.objectListView1.View = System.Windows.Forms.View.Tile;
			this.objectListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.objectListView1_ItemSelectionChanged);
			// 
			// olvColumn1
			// 
			this.olvColumn1.AspectName = "Name";
			this.olvColumn1.CellPadding = null;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1660, 964);
			this.Controls.Add(this.objectListView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Form1";
			this.Text = "Steam Games";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private BrightIdeasSoftware.ObjectListView objectListView1;
		private BrightIdeasSoftware.OLVColumn olvColumn1;
	}
}

