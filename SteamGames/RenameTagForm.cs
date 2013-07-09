using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SteamGames
{
	internal sealed partial class RenameTagForm : Form
	{
		private readonly string currentTag;
		private readonly CheckBox tagCheckbox;
		private readonly State state;

		internal RenameTagForm(CheckBox tagCheckbox, State state)
		{
			currentTag = (string) tagCheckbox.Tag;
			this.tagCheckbox = tagCheckbox;
			this.state = state;
			InitializeComponent();
			label1.Text = string.Format("Rename tag '{0}' to:", currentTag);
			textBox1.Text = currentTag;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (state.Tags.ContainsKey(textBox1.Text))
			{
				MessageBox.Show(string.Format("Can't rename tag to '{0}'. There's already another tag with that name.", textBox1.Text), "Can't rename tag", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			List<int> tagData = state.Tags[currentTag];
			state.Tags.Remove(currentTag);
			state.Tags[textBox1.Text] = tagData;
			tagCheckbox.Tag = textBox1.Text;

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}