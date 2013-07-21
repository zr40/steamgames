namespace SteamGames
{
	internal partial class GamesForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Button RunGameButton;
			System.Windows.Forms.Button CommunityHubButton;
			System.Windows.Forms.Button DeleteTagButton;
			System.Windows.Forms.Button AddTagButton;
			BrightIdeasSoftware.OLVColumn olvColumn1;
			System.Windows.Forms.Panel panel2;
			System.Windows.Forms.Panel FilterPanel;
			System.Windows.Forms.Button AddFilterButton;
			System.Windows.Forms.Label label2;
			this.TagContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.DeleteFilterButton = new System.Windows.Forms.Button();
			this.EditFilterButton = new System.Windows.Forms.Button();
			this.FilterList = new System.Windows.Forms.ListBox();
			this.UninstallGameButton = new System.Windows.Forms.Button();
			this.GameDetailsPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.GameNameLabel = new System.Windows.Forms.Label();
			this.TagListBox = new System.Windows.Forms.ListBox();
			this.TagTextBox = new System.Windows.Forms.TextBox();
			this.GameListView = new BrightIdeasSoftware.ObjectListView();
			this.TagContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			RunGameButton = new System.Windows.Forms.Button();
			CommunityHubButton = new System.Windows.Forms.Button();
			DeleteTagButton = new System.Windows.Forms.Button();
			AddTagButton = new System.Windows.Forms.Button();
			olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			panel2 = new System.Windows.Forms.Panel();
			FilterPanel = new System.Windows.Forms.Panel();
			AddFilterButton = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			panel2.SuspendLayout();
			FilterPanel.SuspendLayout();
			this.GameDetailsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GameListView)).BeginInit();
			this.TagContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// RunGameButton
			// 
			RunGameButton.AutoSize = true;
			RunGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			RunGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			RunGameButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			RunGameButton.ForeColor = System.Drawing.Color.White;
			RunGameButton.Location = new System.Drawing.Point(3, 46);
			RunGameButton.Name = "RunGameButton";
			RunGameButton.Size = new System.Drawing.Size(109, 37);
			RunGameButton.TabIndex = 1;
			RunGameButton.Text = "Run game";
			RunGameButton.UseVisualStyleBackColor = true;
			RunGameButton.Click += new System.EventHandler(this.RunGameButton_Click);
			// 
			// CommunityHubButton
			// 
			CommunityHubButton.AutoSize = true;
			CommunityHubButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			CommunityHubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GameDetailsPanel.SetFlowBreak(CommunityHubButton, true);
			CommunityHubButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			CommunityHubButton.Location = new System.Drawing.Point(118, 46);
			CommunityHubButton.Name = "CommunityHubButton";
			CommunityHubButton.Size = new System.Drawing.Size(161, 37);
			CommunityHubButton.TabIndex = 2;
			CommunityHubButton.Text = "Community Hub";
			CommunityHubButton.UseVisualStyleBackColor = true;
			CommunityHubButton.Click += new System.EventHandler(this.button4_Click);
			// 
			// DeleteTagButton
			// 
			DeleteTagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			DeleteTagButton.ForeColor = System.Drawing.Color.White;
			DeleteTagButton.Location = new System.Drawing.Point(3, 281);
			DeleteTagButton.Name = "DeleteTagButton";
			DeleteTagButton.Size = new System.Drawing.Size(75, 23);
			DeleteTagButton.TabIndex = 4;
			DeleteTagButton.Text = "Delete";
			DeleteTagButton.UseVisualStyleBackColor = true;
			DeleteTagButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// AddTagButton
			// 
			AddTagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			AddTagButton.ForeColor = System.Drawing.Color.White;
			AddTagButton.Location = new System.Drawing.Point(204, 281);
			AddTagButton.Name = "AddTagButton";
			AddTagButton.Size = new System.Drawing.Size(75, 23);
			AddTagButton.TabIndex = 6;
			AddTagButton.Text = "Add";
			AddTagButton.UseVisualStyleBackColor = true;
			AddTagButton.Click += new System.EventHandler(this.button3_Click);
			// 
			// olvColumn1
			// 
			olvColumn1.AspectName = "Name";
			olvColumn1.CellPadding = null;
			// 
			// panel2
			// 
			panel2.Controls.Add(this.TagContainer);
			panel2.Controls.Add(FilterPanel);
			panel2.Dock = System.Windows.Forms.DockStyle.Left;
			panel2.Location = new System.Drawing.Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(200, 914);
			panel2.TabIndex = 5;
			// 
			// TagContainer
			// 
			this.TagContainer.AutoScroll = true;
			this.TagContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TagContainer.Location = new System.Drawing.Point(0, 0);
			this.TagContainer.Name = "TagContainer";
			this.TagContainer.Size = new System.Drawing.Size(200, 703);
			this.TagContainer.TabIndex = 0;
			// 
			// FilterPanel
			// 
			FilterPanel.AutoSize = true;
			FilterPanel.Controls.Add(this.DeleteFilterButton);
			FilterPanel.Controls.Add(this.EditFilterButton);
			FilterPanel.Controls.Add(AddFilterButton);
			FilterPanel.Controls.Add(label2);
			FilterPanel.Controls.Add(this.FilterList);
			FilterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			FilterPanel.Location = new System.Drawing.Point(0, 703);
			FilterPanel.Name = "FilterPanel";
			FilterPanel.Size = new System.Drawing.Size(200, 211);
			FilterPanel.TabIndex = 0;
			// 
			// DeleteFilterButton
			// 
			this.DeleteFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteFilterButton.Location = new System.Drawing.Point(146, 185);
			this.DeleteFilterButton.Name = "DeleteFilterButton";
			this.DeleteFilterButton.Size = new System.Drawing.Size(51, 23);
			this.DeleteFilterButton.TabIndex = 10;
			this.DeleteFilterButton.Text = "Delete";
			this.DeleteFilterButton.UseVisualStyleBackColor = true;
			this.DeleteFilterButton.Click += new System.EventHandler(this.button7_Click);
			// 
			// EditFilterButton
			// 
			this.EditFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditFilterButton.Location = new System.Drawing.Point(73, 185);
			this.EditFilterButton.Name = "EditFilterButton";
			this.EditFilterButton.Size = new System.Drawing.Size(46, 23);
			this.EditFilterButton.TabIndex = 9;
			this.EditFilterButton.Text = "Edit";
			this.EditFilterButton.UseVisualStyleBackColor = true;
			this.EditFilterButton.Click += new System.EventHandler(this.button6_Click);
			// 
			// AddFilterButton
			// 
			AddFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			AddFilterButton.Location = new System.Drawing.Point(3, 185);
			AddFilterButton.Name = "AddFilterButton";
			AddFilterButton.Size = new System.Drawing.Size(42, 23);
			AddFilterButton.TabIndex = 8;
			AddFilterButton.Text = "Add";
			AddFilterButton.UseVisualStyleBackColor = true;
			AddFilterButton.Click += new System.EventHandler(this.button5_Click);
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(12, 3);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(39, 13);
			label2.TabIndex = 0;
			label2.Text = "Show:";
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
			// UninstallGameButton
			// 
			this.UninstallGameButton.AutoSize = true;
			this.UninstallGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.UninstallGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UninstallGameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UninstallGameButton.ForeColor = System.Drawing.Color.White;
			this.UninstallGameButton.Location = new System.Drawing.Point(3, 310);
			this.UninstallGameButton.Name = "UninstallGameButton";
			this.UninstallGameButton.Size = new System.Drawing.Size(126, 33);
			this.UninstallGameButton.TabIndex = 7;
			this.UninstallGameButton.Text = "Uninstall game";
			this.UninstallGameButton.UseVisualStyleBackColor = true;
			this.UninstallGameButton.Click += new System.EventHandler(this.button8_Click);
			// 
			// GameDetailsPanel
			// 
			this.GameDetailsPanel.Controls.Add(this.GameNameLabel);
			this.GameDetailsPanel.Controls.Add(RunGameButton);
			this.GameDetailsPanel.Controls.Add(CommunityHubButton);
			this.GameDetailsPanel.Controls.Add(this.TagListBox);
			this.GameDetailsPanel.Controls.Add(DeleteTagButton);
			this.GameDetailsPanel.Controls.Add(this.TagTextBox);
			this.GameDetailsPanel.Controls.Add(AddTagButton);
			this.GameDetailsPanel.Controls.Add(this.UninstallGameButton);
			this.GameDetailsPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.GameDetailsPanel.Location = new System.Drawing.Point(1378, 0);
			this.GameDetailsPanel.Name = "GameDetailsPanel";
			this.GameDetailsPanel.Size = new System.Drawing.Size(282, 914);
			this.GameDetailsPanel.TabIndex = 3;
			// 
			// GameNameLabel
			// 
			this.GameNameLabel.AutoSize = true;
			this.GameDetailsPanel.SetFlowBreak(this.GameNameLabel, true);
			this.GameNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GameNameLabel.Location = new System.Drawing.Point(3, 0);
			this.GameNameLabel.Name = "GameNameLabel";
			this.GameNameLabel.Size = new System.Drawing.Size(0, 40);
			this.GameNameLabel.TabIndex = 0;
			this.GameNameLabel.UseMnemonic = false;
			// 
			// TagListBox
			// 
			this.TagListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TagListBox.BackColor = System.Drawing.Color.Black;
			this.GameDetailsPanel.SetFlowBreak(this.TagListBox, true);
			this.TagListBox.ForeColor = System.Drawing.Color.White;
			this.TagListBox.Location = new System.Drawing.Point(3, 89);
			this.TagListBox.Name = "TagListBox";
			this.TagListBox.Size = new System.Drawing.Size(277, 186);
			this.TagListBox.TabIndex = 3;
			// 
			// TagTextBox
			// 
			this.TagTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TagTextBox.BackColor = System.Drawing.Color.Black;
			this.TagTextBox.ForeColor = System.Drawing.Color.White;
			this.TagTextBox.Location = new System.Drawing.Point(84, 281);
			this.TagTextBox.Name = "TagTextBox";
			this.TagTextBox.Size = new System.Drawing.Size(114, 22);
			this.TagTextBox.TabIndex = 5;
			// 
			// GameListView
			// 
			this.GameListView.AllColumns.Add(olvColumn1);
			this.GameListView.BackColor = System.Drawing.Color.Black;
			this.GameListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.GameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            olvColumn1});
			this.GameListView.CopySelectionOnControlC = false;
			this.GameListView.CopySelectionOnControlCUsesDragSource = false;
			this.GameListView.Cursor = System.Windows.Forms.Cursors.Default;
			this.GameListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GameListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GameListView.ForeColor = System.Drawing.Color.White;
			this.GameListView.Location = new System.Drawing.Point(200, 0);
			this.GameListView.MultiSelect = false;
			this.GameListView.Name = "GameListView";
			this.GameListView.OwnerDraw = true;
			this.GameListView.ShowGroups = false;
			this.GameListView.ShowHeaderInAllViews = false;
			this.GameListView.ShowImagesOnSubItems = true;
			this.GameListView.Size = new System.Drawing.Size(1178, 914);
			this.GameListView.TabIndex = 0;
			this.GameListView.TileSize = new System.Drawing.Size(188, 99);
			this.GameListView.UseCompatibleStateImageBehavior = false;
			this.GameListView.View = System.Windows.Forms.View.Tile;
			this.GameListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.objectListView1_ItemSelectionChanged);
			// 
			// TagContextMenuStrip
			// 
			this.TagContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameTagToolStripMenuItem,
            this.deleteTagToolStripMenuItem});
			this.TagContextMenuStrip.Name = "contextMenuStrip1";
			this.TagContextMenuStrip.Size = new System.Drawing.Size(147, 48);
			// 
			// renameTagToolStripMenuItem
			// 
			this.renameTagToolStripMenuItem.Name = "renameTagToolStripMenuItem";
			this.renameTagToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.renameTagToolStripMenuItem.Text = "Rename tag...";
			this.renameTagToolStripMenuItem.Click += new System.EventHandler(this.renameTagToolStripMenuItem_Click);
			// 
			// deleteTagToolStripMenuItem
			// 
			this.deleteTagToolStripMenuItem.Name = "deleteTagToolStripMenuItem";
			this.deleteTagToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.deleteTagToolStripMenuItem.Text = "Delete tag...";
			this.deleteTagToolStripMenuItem.Click += new System.EventHandler(this.deleteTagToolStripMenuItem_Click);
			// 
			// GamesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1660, 914);
			this.Controls.Add(this.GameListView);
			this.Controls.Add(panel2);
			this.Controls.Add(this.GameDetailsPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "GamesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Steam Games";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			FilterPanel.ResumeLayout(false);
			FilterPanel.PerformLayout();
			this.GameDetailsPanel.ResumeLayout(false);
			this.GameDetailsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GameListView)).EndInit();
			this.TagContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel TagContainer;
		private System.Windows.Forms.FlowLayoutPanel GameDetailsPanel;
		private System.Windows.Forms.Label GameNameLabel;
		private System.Windows.Forms.ListBox TagListBox;
		private System.Windows.Forms.TextBox TagTextBox;
		private BrightIdeasSoftware.ObjectListView GameListView;
		private System.Windows.Forms.Button DeleteFilterButton;
		private System.Windows.Forms.Button EditFilterButton;
		private System.Windows.Forms.ListBox FilterList;
		private System.Windows.Forms.ContextMenuStrip TagContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem renameTagToolStripMenuItem;
		private System.Windows.Forms.Button UninstallGameButton;
		private System.Windows.Forms.ToolStripMenuItem deleteTagToolStripMenuItem;
	}
}

