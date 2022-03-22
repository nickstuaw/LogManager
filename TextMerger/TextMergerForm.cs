namespace TextMerger
{
    public partial class TextMergerForm : Form
    {
        FolderBrowserDialog outputFolderDialog = new FolderBrowserDialog(),
            inputFolderDialog = new FolderBrowserDialog();
        public TextMergerForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputFolderDialog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Merge
            string[] files = Directory.GetFiles(inputFolderDialog.SelectedPath);
            string output = "";
            foreach(string file in files)
            {
                if (file.EndsWith(extensionText.Text))
                {
                    output += file.Substring(0, 10) + "\n";
                    output += File.ReadAllText(file);
                }
            }
            File.AppendAllText(outputFolderDialog.SelectedPath + "/" + filenameBox.Text + "." + extensionText.Text, output);
            MessageBox.Show("Transfer complete!", "Done!");
        }

        private void folderChosen_Click(object sender, EventArgs e)
        {
            inputFolderDialog.ShowDialog();
        }
    }
}