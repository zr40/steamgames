namespace SteamGames
{
	internal partial class LoadingForm
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
			this.label1 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			button1.Location = new System.Drawing.Point(220, 11);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Cancel";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loading saved state...";
			// 
			// LoadingForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.CancelButton = button1;
			this.ClientSize = new System.Drawing.Size(307, 46);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(button1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoadingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Initializing Steam Games...";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingForm_FormClosed);
			this.Load += new System.EventHandler(this.LoadingForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;


	}
}