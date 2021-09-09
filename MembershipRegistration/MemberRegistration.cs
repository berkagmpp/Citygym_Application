using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MembershipRegistration
{
    public partial class MemberRegistration : Form
    {
        public MemberRegistration()
        {
            InitializeComponent();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void TextBox_FirstName_TextChanged(object sender, EventArgs e)
        {
        }
        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            // Check the validation for calculating
            if (CheckValidation())
            {
                // Display Duration user selected
                if (radioButton_Duration_3months.Checked)
                {
                    textBox_Cost_Duration.Text = " " + radioButton_Duration_3months.Text;
                }
                else if (radioButton_Duration_12months.Checked)
                {
                    textBox_Cost_Duration.Text = " " + radioButton_Duration_12months.Text;
                }
                else if (radioButton_Duration_24months.Checked)
                {
                    textBox_Cost_Duration.Text = " " + radioButton_Duration_24months.Text;
                }
                else
                {
                    textBox_Cost_Duration.Text = "Something is wrong.";
                }

                // Convert from monthly to weekly
                double weeks = Duraion_select() * 4.28;

                // Calculate Membership cost (befor discount)
                double calMembershipCost = MembershipCost_select() * weeks;

                // Display Membership cost (befor discount)
                textBox_Cost_MembershipCost.Text = " $ " + Math.Round((calMembershipCost), 2);

                // Calculate Duration discount
                double durationDiscount = Duraion_discount() * weeks;
                // Calculate Direct debit discount
                double directDebitDiscount = MembershipCost_select() * weeks * PaymentMethod_select();
                // Calculate Total discount
                double totalDiscount = durationDiscount + directDebitDiscount;
                // Display Total discount
                textBox_Cost_TotalDiscount.Text = " $ " + Math.Round((totalDiscount), 2);

                // Calculate Extra charges
                double extraCharges = (Extra_Access_checked() + Extra_PT_checked() + Extra_DietConsult_checked() + Extra_OnlineVideos_checked()) * weeks;
                // Display Extra charges
                textBox_Cost_ExtraCharges.Text = " $ " + Math.Round((extraCharges), 2); ;

                // Calculate Net membership cost
                double netMembershipCost = calMembershipCost - totalDiscount + extraCharges;
                // Display Net membership cost
                textBox_Cost_Net.Text = " $ " + Math.Round((netMembershipCost), 2);

                // Calculate Regular payment amount
                if (radioButton_PayFrequancy_Weekly.Checked)
                {
                    textBox_Cost_RegularAmount.Text = " Weekly : $ " + Math.Round((netMembershipCost / weeks), 2);
                }
                else
                {
                    textBox_Cost_RegularAmount.Text = " Monthly : $ " + Math.Round((netMembershipCost / Duraion_select()), 2);
                }
            }
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                if (String.IsNullOrWhiteSpace(textBox_Cost_RegularAmount.Text))
                {
                    // If the registration cost is empty, request to press the Calculation button before submitting
                    MessageBox.Show("Please press Calculate button.", "Error");
                }
                else
                {
                    var submitConfirmResult = MessageBox.Show("Are you sure to submit these?",
                                            "Confirm Submit!",
                                            MessageBoxButtons.YesNo);
                    // If 'Yes', do a validation check for saving data and then make file and write
                    if (submitConfirmResult == DialogResult.Yes)
                    {
                        // Save the text file in C:\Temp and set file name with current DateTime and name as the ID
                        string fileName = ("C:\\Temp\\" + DateTime.Now.ToString("yyyyMMddHHmmdd") + "_" + textBox_FirstName.Text + "-" + textBox_LastName.Text + ".txt");
                        StreamWriter wr = File.CreateText(fileName);
                        wr.WriteLine("* Name: " + textBox_FirstName.Text + " " + textBox_LastName.Text);
                        wr.WriteLine("* Address: " + textBox_Street.Text + ", " +  textBox_City.Text);
                        wr.WriteLine("* Phone: " + textBox_Phone.Text);
                        wr.WriteLine("* Type of membership: " + Text_Membership_select());
                        wr.WriteLine("* Duration: " + Duraion_select() + "months");
                        wr.WriteLine("* Payment method: " + Text_PaymentMethod_select());
                        wr.WriteLine("* Payment frequancy: " + Text_PaymentFrequancy_select());
                        wr.WriteLine("* Extras: " + Text_Extra_Access_checked() + " " + Text_Extra_PT_checked() + " " + Text_Extra_DietConsult_checked() + " " + Text_Extra_OnlineVideos_checked());
                        wr.WriteLine("----------------------------------------------------------");
                        wr.WriteLine("* Membership cost: " + textBox_Cost_MembershipCost.Text);
                        wr.WriteLine("* Total discount: " + textBox_Cost_TotalDiscount.Text);
                        wr.WriteLine("* Extra charges: " + textBox_Cost_ExtraCharges.Text);
                        wr.WriteLine("* Net membership cost: " + textBox_Cost_Net.Text);
                        wr.WriteLine("* Regular payment amount: " + textBox_Cost_RegularAmount.Text);
                        wr.Close();
                        MessageBox.Show("Submit complete.");
                    }
                }
            }
        }
        private void Button_Reset_Click(object sender, EventArgs e)
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
                    foreach (RadioButton radioButton in panel.Controls.OfType<RadioButton>())
                    {
                        radioButton.Checked = false;
                    }
                    foreach (CheckBox checkBox in panel.Controls.OfType<CheckBox>())
                    {
                        checkBox.Checked = false;
                    }
                }
                MessageBox.Show("Reset complete.");
            }
        }
        private bool CheckValidation()
        {
            // Show an error message by check null or white space in textBox
            if (String.IsNullOrWhiteSpace(textBox_FirstName.Text))
            {
                MessageBox.Show("Please enter your First name.");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox_LastName.Text))
            {
                MessageBox.Show("Please enter your Last name.");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox_Street.Text))
            {
                MessageBox.Show("Please enter the Street in your Address.");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox_City.Text))
            {
                MessageBox.Show("Please enter the City in your Address.");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox_Phone.Text))
            {
                MessageBox.Show("Please enter your Phone number.");
                return false;
            }
            // Show an error message with set the type(int) a user can manually type in Phone
            else if (int.TryParse(textBox_Phone.Text, out _) == false)
            {
                MessageBox.Show("Please enter the number in Phone.");
                return false;
            }
            // Show an error message if none of the radio buttons is selected in each section
            else if (!radioButton_Type_Basic.Checked && !radioButton_Type_Regular.Checked && !radioButton_Type_Premium.Checked)
            {
                MessageBox.Show("Please select the Type of membership.", "Error");
                return false;
            }
            else if (!radioButton_Duration_3months.Checked && !radioButton_Duration_12months.Checked && !radioButton_Duration_24months.Checked)
            {
                MessageBox.Show("Please select the Duration.", "Error");
                return false;
            }
            else if (!radioButton_PayMethod_CreditCard.Checked && !radioButton_PayMethod_DirectDebit.Checked)
            {
                MessageBox.Show("Please select the Payment method.", "Error");
                return false;
            }
            else if (!radioButton_PayFrequancy_Weekly.Checked && !radioButton_PayFrequancy_Monthly.Checked)
            {
                MessageBox.Show("Please select the Payment frequancy.", "Error");
                return false;
            }
            return true;
        }
        private int Duraion_select()
        {
            if (radioButton_Duration_3months.Checked)
            {
                return 3;
            }
            else if (radioButton_Duration_12months.Checked)
            {
                return 12;
            }
            else if (radioButton_Duration_24months.Checked)
            {
                return 24;
            }
            else
            {
                return 0;
            }
        }
        private double Duraion_discount()
        {
            if (radioButton_Duration_12months.Checked)
            {
                return 2;
            }
            else if (radioButton_Duration_24months.Checked)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
        private int MembershipCost_select()
        {
            if (radioButton_Type_Basic.Checked)
            {
                return 10;
            }
            else if (radioButton_Type_Regular.Checked)
            {
                return 15;
            }
            else if (radioButton_Type_Premium.Checked)
            {
                return 20;
            }
            else
            {
                return 0;
            }
        }
        private string Text_Membership_select()
        {
            if (radioButton_Type_Basic.Checked)
            {
                return "Basic ($10 per week)";
            }
            else if (radioButton_Type_Regular.Checked)
            {
                return "Regualr ($15 per week)";
            }
            else if (radioButton_Type_Premium.Checked)
            {
                return "Premium ($20 per week)";
            }
            else
            {
                return "Something is wrong.";
            }
        }
        private string Text_PaymentMethod_select()
        {
            if (radioButton_PayMethod_CreditCard.Checked)
            {
                return "Credit Card";
            }
            else if (radioButton_PayMethod_DirectDebit.Checked)
            {
                return "Direct Debit (1% discount on the base membership cost)";
            }
            else
            {
                return "Something is wrong.";
            }
        }
        private double PaymentMethod_select()
        {
            if (radioButton_PayMethod_DirectDebit.Checked)
            {
                return 0.01;
            }
            else
            {
                return 0;
            }
        }
        private string Text_PaymentFrequancy_select()
        {
            if (radioButton_PayFrequancy_Weekly.Checked)
            {
                return "Weekly";
            }
            else if (radioButton_PayFrequancy_Monthly.Checked)
            {
                return "Monthly";
            }
            else
            {
                return "Something is wrong.";
            }
        }
        private int Extra_Access_checked()
        {
            if (checkBox_Extras_Access.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private int Extra_PT_checked()
        {
            if (checkBox_Extras_PT.Checked)
                return 20;
            else
            {
                return 0;
            }
        }
        private int Extra_DietConsult_checked()
        {
            if (checkBox_Extras_DietConsult.Checked)
            {
                return 20;
            }
            else
            {
                return 0;
            }
        }
        private int Extra_OnlineVideos_checked()
        {
            if (checkBox_Extras_OnlineVideos.Checked)

            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        private string Text_Extra_Access_checked()
        {
            if (checkBox_Extras_Access.Checked)
            {
                return "24/7 Access ($1 per week)";
            }
            else
            {
                return "";
            }
        }
        private string Text_Extra_PT_checked()
        {
            if (checkBox_Extras_PT.Checked)
            {
                return "Personal trainer ($20 per week)";
            }
            else
            {
                return "";
            }
        }
        private string Text_Extra_DietConsult_checked()
        {
            if (checkBox_Extras_DietConsult.Checked)
            {
                return "Diet consultation ($20 per week)";
            }
            else
            {
                return "";
            }
        }
        private string Text_Extra_OnlineVideos_checked()
        {
            if (checkBox_Extras_OnlineVideos.Checked)
            {
                return "Online fitness videos ($2 per week)";
            }
            else
            {
                return "";
            }
        }

    }
}
