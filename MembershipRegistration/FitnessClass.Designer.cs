
namespace MembershipRegistration
{
    partial class FitnessClass
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TextBox_StartDateWeek = new System.Windows.Forms.TextBox();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.TextBox_EndDateWeek = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_FC_SM_SearchMember = new System.Windows.Forms.Button();
            this.TextBox_FC_SM = new System.Windows.Forms.TextBox();
            this.Button_FC_SM_Reset = new System.Windows.Forms.Button();
            this.Button_FC_SM_Next = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_FC_Date = new System.Windows.Forms.Panel();
            this.Button_FC_Date_Reset = new System.Windows.Forms.Button();
            this.Button_FC_Date_Conform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_FC_Submit = new System.Windows.Forms.Button();
            this.Button_FC_ResetAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel_FC_Date.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthCalendar1.Location = new System.Drawing.Point(6, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // TextBox_StartDateWeek
            // 
            this.TextBox_StartDateWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.TextBox_StartDateWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_StartDateWeek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_StartDateWeek.ForeColor = System.Drawing.Color.White;
            this.TextBox_StartDateWeek.Location = new System.Drawing.Point(22, 30);
            this.TextBox_StartDateWeek.Name = "TextBox_StartDateWeek";
            this.TextBox_StartDateWeek.Size = new System.Drawing.Size(226, 22);
            this.TextBox_StartDateWeek.TabIndex = 2;
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StartDate.ForeColor = System.Drawing.Color.White;
            this.label_StartDate.Location = new System.Drawing.Point(19, 10);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(166, 16);
            this.label_StartDate.TabIndex = 4;
            this.label_StartDate.Text = "Start date of selected week";
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EndDate.ForeColor = System.Drawing.Color.White;
            this.label_EndDate.Location = new System.Drawing.Point(19, 59);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(161, 16);
            this.label_EndDate.TabIndex = 6;
            this.label_EndDate.Text = "End date of selected week";
            // 
            // TextBox_EndDateWeek
            // 
            this.TextBox_EndDateWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.TextBox_EndDateWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_EndDateWeek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_EndDateWeek.ForeColor = System.Drawing.Color.White;
            this.TextBox_EndDateWeek.Location = new System.Drawing.Point(21, 80);
            this.TextBox_EndDateWeek.Name = "TextBox_EndDateWeek";
            this.TextBox_EndDateWeek.Size = new System.Drawing.Size(227, 22);
            this.TextBox_EndDateWeek.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label_StartDate);
            this.panel1.Controls.Add(this.label_EndDate);
            this.panel1.Controls.Add(this.TextBox_StartDateWeek);
            this.panel1.Controls.Add(this.TextBox_EndDateWeek);
            this.panel1.Location = new System.Drawing.Point(238, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 116);
            this.panel1.TabIndex = 7;
            // 
            // Button_FC_SM_SearchMember
            // 
            this.Button_FC_SM_SearchMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Button_FC_SM_SearchMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_FC_SM_SearchMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.Button_FC_SM_SearchMember.FlatAppearance.BorderSize = 3;
            this.Button_FC_SM_SearchMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Button_FC_SM_SearchMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Button_FC_SM_SearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FC_SM_SearchMember.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FC_SM_SearchMember.ForeColor = System.Drawing.Color.White;
            this.Button_FC_SM_SearchMember.Location = new System.Drawing.Point(5, 23);
            this.Button_FC_SM_SearchMember.Name = "Button_FC_SM_SearchMember";
            this.Button_FC_SM_SearchMember.Size = new System.Drawing.Size(133, 30);
            this.Button_FC_SM_SearchMember.TabIndex = 95;
            this.Button_FC_SM_SearchMember.Text = "Search Member";
            this.Button_FC_SM_SearchMember.UseVisualStyleBackColor = false;
            this.Button_FC_SM_SearchMember.Click += new System.EventHandler(this.Button_FC_SearchMember_Click);
            // 
            // TextBox_FC_SM
            // 
            this.TextBox_FC_SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TextBox_FC_SM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_FC_SM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_FC_SM.ForeColor = System.Drawing.Color.White;
            this.TextBox_FC_SM.Location = new System.Drawing.Point(153, 29);
            this.TextBox_FC_SM.Name = "TextBox_FC_SM";
            this.TextBox_FC_SM.Size = new System.Drawing.Size(181, 21);
            this.TextBox_FC_SM.TabIndex = 96;
            // 
            // Button_FC_SM_Reset
            // 
            this.Button_FC_SM_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.Button_FC_SM_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_FC_SM_Reset.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Button_FC_SM_Reset.FlatAppearance.BorderSize = 3;
            this.Button_FC_SM_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_FC_SM_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_FC_SM_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FC_SM_Reset.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FC_SM_Reset.ForeColor = System.Drawing.Color.White;
            this.Button_FC_SM_Reset.Location = new System.Drawing.Point(344, 23);
            this.Button_FC_SM_Reset.Name = "Button_FC_SM_Reset";
            this.Button_FC_SM_Reset.Size = new System.Drawing.Size(60, 30);
            this.Button_FC_SM_Reset.TabIndex = 97;
            this.Button_FC_SM_Reset.Text = "Reset";
            this.Button_FC_SM_Reset.UseVisualStyleBackColor = false;
            // 
            // Button_FC_SM_Next
            // 
            this.Button_FC_SM_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button_FC_SM_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_FC_SM_Next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.Button_FC_SM_Next.FlatAppearance.BorderSize = 3;
            this.Button_FC_SM_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Button_FC_SM_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Button_FC_SM_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FC_SM_Next.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FC_SM_Next.ForeColor = System.Drawing.Color.White;
            this.Button_FC_SM_Next.Location = new System.Drawing.Point(414, 23);
            this.Button_FC_SM_Next.Name = "Button_FC_SM_Next";
            this.Button_FC_SM_Next.Size = new System.Drawing.Size(92, 30);
            this.Button_FC_SM_Next.TabIndex = 98;
            this.Button_FC_SM_Next.Text = "Next";
            this.Button_FC_SM_Next.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TextBox_FC_SM);
            this.panel2.Controls.Add(this.Button_FC_SM_Next);
            this.panel2.Controls.Add(this.Button_FC_SM_SearchMember);
            this.panel2.Controls.Add(this.Button_FC_SM_Reset);
            this.panel2.Location = new System.Drawing.Point(61, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 56);
            this.panel2.TabIndex = 99;
            // 
            // Panel_FC_Date
            // 
            this.Panel_FC_Date.Controls.Add(this.label2);
            this.Panel_FC_Date.Controls.Add(this.Button_FC_Date_Conform);
            this.Panel_FC_Date.Controls.Add(this.Button_FC_Date_Reset);
            this.Panel_FC_Date.Controls.Add(this.monthCalendar1);
            this.Panel_FC_Date.Controls.Add(this.panel1);
            this.Panel_FC_Date.Location = new System.Drawing.Point(61, 165);
            this.Panel_FC_Date.Name = "Panel_FC_Date";
            this.Panel_FC_Date.Size = new System.Drawing.Size(508, 197);
            this.Panel_FC_Date.TabIndex = 100;
            // 
            // Button_FC_Date_Reset
            // 
            this.Button_FC_Date_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.Button_FC_Date_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_FC_Date_Reset.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Button_FC_Date_Reset.FlatAppearance.BorderSize = 3;
            this.Button_FC_Date_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_FC_Date_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_FC_Date_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FC_Date_Reset.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FC_Date_Reset.ForeColor = System.Drawing.Color.White;
            this.Button_FC_Date_Reset.Location = new System.Drawing.Point(240, 152);
            this.Button_FC_Date_Reset.Name = "Button_FC_Date_Reset";
            this.Button_FC_Date_Reset.Size = new System.Drawing.Size(94, 35);
            this.Button_FC_Date_Reset.TabIndex = 98;
            this.Button_FC_Date_Reset.Text = "Reset";
            this.Button_FC_Date_Reset.UseVisualStyleBackColor = false;
            this.Button_FC_Date_Reset.Click += new System.EventHandler(this.Button_FC_Date_Reset_Click);
            // 
            // Button_FC_Date_Conform
            // 
            this.Button_FC_Date_Conform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button_FC_Date_Conform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_FC_Date_Conform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.Button_FC_Date_Conform.FlatAppearance.BorderSize = 3;
            this.Button_FC_Date_Conform.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Button_FC_Date_Conform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Button_FC_Date_Conform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FC_Date_Conform.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FC_Date_Conform.ForeColor = System.Drawing.Color.White;
            this.Button_FC_Date_Conform.Location = new System.Drawing.Point(344, 152);
            this.Button_FC_Date_Conform.Name = "Button_FC_Date_Conform";
            this.Button_FC_Date_Conform.Size = new System.Drawing.Size(161, 35);
            this.Button_FC_Date_Conform.TabIndex = 99;
            this.Button_FC_Date_Conform.Text = "Confirm";
            this.Button_FC_Date_Conform.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "1. Select a member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 102;
            this.label2.Text = "2. Select a week to start";
            // 
            // Button_FC_Submit
            // 
            this.Button_FC_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button_FC_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_FC_Submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.Button_FC_Submit.FlatAppearance.BorderSize = 3;
            this.Button_FC_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Button_FC_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.Button_FC_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FC_Submit.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FC_Submit.ForeColor = System.Drawing.Color.White;
            this.Button_FC_Submit.Location = new System.Drawing.Point(394, 626);
            this.Button_FC_Submit.Name = "Button_FC_Submit";
            this.Button_FC_Submit.Size = new System.Drawing.Size(175, 38);
            this.Button_FC_Submit.TabIndex = 99;
            this.Button_FC_Submit.Text = "Submit";
            this.Button_FC_Submit.UseVisualStyleBackColor = false;
            // 
            // Button_FC_ResetAll
            // 
            this.Button_FC_ResetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.Button_FC_ResetAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_FC_ResetAll.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Button_FC_ResetAll.FlatAppearance.BorderSize = 3;
            this.Button_FC_ResetAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_FC_ResetAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_FC_ResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FC_ResetAll.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FC_ResetAll.ForeColor = System.Drawing.Color.White;
            this.Button_FC_ResetAll.Location = new System.Drawing.Point(293, 626);
            this.Button_FC_ResetAll.Name = "Button_FC_ResetAll";
            this.Button_FC_ResetAll.Size = new System.Drawing.Size(89, 38);
            this.Button_FC_ResetAll.TabIndex = 98;
            this.Button_FC_ResetAll.Text = "Reset All";
            this.Button_FC_ResetAll.UseVisualStyleBackColor = false;
            this.Button_FC_ResetAll.Click += new System.EventHandler(this.Button_FC_ResetAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 26);
            this.label4.TabIndex = 102;
            this.label4.Text = "Fitness Class Booking";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.LightGray;
            this.label33.Location = new System.Drawing.Point(64, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(325, 15);
            this.label33.TabIndex = 113;
            this.label33.Text = "SEARCH FOR MEMBERS BY NAME, PHONE OR MEMBERSHIP TYPE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 102;
            this.label3.Text = "3. Select a class";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(61, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 235);
            this.panel3.TabIndex = 101;
            // 
            // FitnessClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(634, 751);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Button_FC_Submit);
            this.Controls.Add(this.Panel_FC_Date);
            this.Controls.Add(this.Button_FC_ResetAll);
            this.Controls.Add(this.panel2);
            this.Name = "FitnessClass";
            this.Text = "FitnessClass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Panel_FC_Date.ResumeLayout(false);
            this.Panel_FC_Date.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox TextBox_StartDateWeek;
        private System.Windows.Forms.Label label_StartDate;
        private System.Windows.Forms.Label label_EndDate;
        private System.Windows.Forms.TextBox TextBox_EndDateWeek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_FC_SM_SearchMember;
        private System.Windows.Forms.TextBox TextBox_FC_SM;
        private System.Windows.Forms.Button Button_FC_SM_Reset;
        private System.Windows.Forms.Button Button_FC_SM_Next;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panel_FC_Date;
        private System.Windows.Forms.Button Button_FC_Date_Conform;
        private System.Windows.Forms.Button Button_FC_Date_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_FC_Submit;
        private System.Windows.Forms.Button Button_FC_ResetAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}