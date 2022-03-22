using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextMerger
{
    public partial class SearchForm : Form
    {
        OpenFileDialog open;
        string log_file;
        string username, uuid;

        public SearchForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void singleDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            datesGroupBox.Enabled = !singleDateCheckbox.Checked;
            singleDatePicker.Enabled = singleDateCheckbox.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            playerGroupBox.Enabled = playerCheckBox.Checked;
        }

        private void playerUsernameCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            playerUsernameText.Enabled = playerUsernameCheckbox.Checked;
        }

        private void playerUUIDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            playerUUIDText.Enabled = playerUUIDCheckbox.Checked;
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void playerUUIDText_TextChanged(object sender, EventArgs e)
        {
            uuid = playerUUIDText.Text;
        }

        private void playerUsernameText_TextChanged(object sender, EventArgs e)
        {
            username = playerUsernameText.Text;
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|.txt|Log files (*.log)|.log|All files (*.*)|*.*";
            open.ShowDialog();
        }

        private void search()
        {
            // Open a StreamReader of the chosen file.
            StreamReader reader = new StreamReader(open.OpenFile());
            // Declare line to store the current line in each iteration.
            string line;
            // Set date to now because it needs to be assigned. This is just a placeholder.
            DateTime date = new DateTime();
            // Set current. This will store the date and time of the current line.
            DateTime current;
            // Iterate through every line until the file ends.
            for(line = reader.ReadLine(); line != null; line = reader.ReadLine())
            {
                // If the line is null, break. This might be unnecessary.
                if (line == null) 
                    break;
                // If the line starts with [, assume it is a normal log line (and not a date.
                // If it doesn't, it is probably a date indicator from the TextMerger that indicates the "current date".
                if (!line.StartsWith("["))
                    // Save the "current date" to date.
                    DateTime.TryParse(line, out date);
                else
                {
                    // Set current to the current date.
                    current = date;
                    // Add the timestamp shown by the current log line.
                    current.Add(TimeSpan.Parse(line.Substring(1, 8)));
                    // current now contains the date and time of the log line.
                    // Compare it with the limit.
                    if (!dateMeetsLimits(current))
                        // If the date hasn't met the limits, ignore the line.
                        continue;
                    else
                    {
                        // If the date is within limits, scan the line.
                        if(playerCheckBox.Checked)
                        {
                            // If searching player name, check if the line has a player's name
                            if()
                            {
                                line.Contains();
                            }
                            if (commandCheckBox.Checked)
                            {
                                // scan for a command
                            }
                        }
                    }
                }
            }
        }

        private bool dateMeetsLimits(DateTime date)
        {
            // If a single date is being used
            if (singleDateCheckbox.Checked)
            {
                // then check if the current date matches the chosen date.
                if (compareDates(date, singleDatePicker.Value))
                    return true;
            }
            else
            {
                // If the date limits are being used, compare them against the current date.
                if (compareDates(date, startDatePicker.Value, endDatePicker.Value))
                    // If the current date is within limits, it is within limits.
                    return true;
            }
            // The date isn't within any limits.
            return false;
        }

        private bool compareDates(DateTime date, DateTime minDate, DateTime maxDate)
        {
            int result1 = DateTime.Compare(minDate, date), result2 = DateTime.Compare(date, maxDate);
            return result1 < 0 && result2 < 0;
        }

        private bool compareDates(DateTime date, DateTime date2)
        {
            return date.Date.Equals(date2.Date);
        }
    }
}
