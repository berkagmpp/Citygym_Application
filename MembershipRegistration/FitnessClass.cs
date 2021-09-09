using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipRegistration
{
    public partial class FitnessClass : Form
    {
        public FitnessClass()
        {
            InitializeComponent();
            // Create the calendar.
        }
        private void Button_FC_SearchMember_Click(object sender, EventArgs e)
        {

        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // User selected day
            DateTime startDate = e.Start;
            // Set start and end days of a week from user selected day
            startDate = startDate.AddDays(-(double)startDate.DayOfWeek);
            DateTime endDate = startDate.AddDays(6);
            monthCalendar1.SelectionStart = startDate;
            monthCalendar1.SelectionEnd = endDate;
            // Convert dates to string and display
            string convertedStartDate = startDate.ToString("yyyy/MM/dd/ddd");
            string convertedEndDate = endDate.ToString("yyyy/MM/dd/ddd");
            TextBox_StartDateWeek.Text = convertedStartDate;
            TextBox_EndDateWeek.Text = convertedEndDate;

        }

        private void Button_FC_Date_Reset_Click(object sender, EventArgs e)
        {
        }

        private void Button_FC_ResetAll_Click(object sender, EventArgs e)
        {
            // The reset confirmation dialogue box 
            var resetConfirmResult = MessageBox.Show("Are you sure to clear all?",
                                                             "Confirm Reset!",
                                                             MessageBoxButtons.YesNo);
            if (resetConfirmResult == DialogResult.Yes)
            {
                // If 'Yes', do clear all data
                foreach (Panel panel in this.Controls.OfType<Panel>())
                {
                    foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
                    {
                        textBox.Text = null;
                    }
                    foreach (CheckBox checkBox in panel.Controls.OfType<CheckBox>())
                    {
                        checkBox.Checked = false;
                    }
                }
                MessageBox.Show("Reset complete.");
            }
        }
    }
}
