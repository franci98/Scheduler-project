namespace Scheduler.Forms
{
    partial class ScheduleNew
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
            this.ScheduleTitleTextBox = new System.Windows.Forms.TextBox();
            this.InsertScheduleComboBox = new System.Windows.Forms.GroupBox();
            this.InsertSchedule = new System.Windows.Forms.Button();
            this.InsertLessonComboBox = new System.Windows.Forms.GroupBox();
            this.LessonAddButton = new System.Windows.Forms.Button();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.HourComboBox = new System.Windows.Forms.ComboBox();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.CommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.InsertScheduleComboBox.SuspendLayout();
            this.InsertLessonComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScheduleTitleTextBox
            // 
            this.ScheduleTitleTextBox.Location = new System.Drawing.Point(6, 19);
            this.ScheduleTitleTextBox.Name = "ScheduleTitleTextBox";
            this.ScheduleTitleTextBox.Size = new System.Drawing.Size(172, 20);
            this.ScheduleTitleTextBox.TabIndex = 0;
            // 
            // InsertScheduleComboBox
            // 
            this.InsertScheduleComboBox.Controls.Add(this.InsertSchedule);
            this.InsertScheduleComboBox.Controls.Add(this.ScheduleTitleTextBox);
            this.InsertScheduleComboBox.Location = new System.Drawing.Point(12, 12);
            this.InsertScheduleComboBox.Name = "InsertScheduleComboBox";
            this.InsertScheduleComboBox.Size = new System.Drawing.Size(265, 56);
            this.InsertScheduleComboBox.TabIndex = 1;
            this.InsertScheduleComboBox.TabStop = false;
            this.InsertScheduleComboBox.Text = "Vnesite ime urnika";
            // 
            // InsertSchedule
            // 
            this.InsertSchedule.Location = new System.Drawing.Point(184, 17);
            this.InsertSchedule.Name = "InsertSchedule";
            this.InsertSchedule.Size = new System.Drawing.Size(75, 23);
            this.InsertSchedule.TabIndex = 1;
            this.InsertSchedule.Text = "Vnesi";
            this.InsertSchedule.UseVisualStyleBackColor = true;
            this.InsertSchedule.Click += new System.EventHandler(this.InsertSchedule_Click);
            // 
            // InsertLessonComboBox
            // 
            this.InsertLessonComboBox.Controls.Add(this.RatingComboBox);
            this.InsertLessonComboBox.Controls.Add(this.CommentRichTextBox);
            this.InsertLessonComboBox.Controls.Add(this.LessonAddButton);
            this.InsertLessonComboBox.Controls.Add(this.SubjectComboBox);
            this.InsertLessonComboBox.Controls.Add(this.HourComboBox);
            this.InsertLessonComboBox.Controls.Add(this.DayComboBox);
            this.InsertLessonComboBox.Location = new System.Drawing.Point(13, 75);
            this.InsertLessonComboBox.Name = "InsertLessonComboBox";
            this.InsertLessonComboBox.Size = new System.Drawing.Size(517, 165);
            this.InsertLessonComboBox.TabIndex = 2;
            this.InsertLessonComboBox.TabStop = false;
            this.InsertLessonComboBox.Text = "Dodaj šolsko uro";
            this.InsertLessonComboBox.Visible = false;
            this.InsertLessonComboBox.VisibleChanged += new System.EventHandler(this.InsertLessonComboBox_VisibleChanged);
            // 
            // LessonAddButton
            // 
            this.LessonAddButton.Location = new System.Drawing.Point(389, 18);
            this.LessonAddButton.Name = "LessonAddButton";
            this.LessonAddButton.Size = new System.Drawing.Size(75, 23);
            this.LessonAddButton.TabIndex = 3;
            this.LessonAddButton.Text = "Dodaj uro";
            this.LessonAddButton.UseVisualStyleBackColor = true;
            this.LessonAddButton.Click += new System.EventHandler(this.LessonAddButton_Click);
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Location = new System.Drawing.Point(262, 20);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(121, 21);
            this.SubjectComboBox.TabIndex = 2;
            this.SubjectComboBox.Text = "Izberi predmet";
            // 
            // HourComboBox
            // 
            this.HourComboBox.FormattingEnabled = true;
            this.HourComboBox.Location = new System.Drawing.Point(134, 20);
            this.HourComboBox.Name = "HourComboBox";
            this.HourComboBox.Size = new System.Drawing.Size(121, 21);
            this.HourComboBox.TabIndex = 1;
            this.HourComboBox.Text = "Izberi uro";
            // 
            // DayComboBox
            // 
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Location = new System.Drawing.Point(7, 20);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(121, 21);
            this.DayComboBox.TabIndex = 0;
            this.DayComboBox.Text = "Izberi dan";
            // 
            // CommentRichTextBox
            // 
            this.CommentRichTextBox.Location = new System.Drawing.Point(146, 71);
            this.CommentRichTextBox.Name = "CommentRichTextBox";
            this.CommentRichTextBox.Size = new System.Drawing.Size(318, 64);
            this.CommentRichTextBox.TabIndex = 4;
            this.CommentRichTextBox.Text = "";
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RatingComboBox.Location = new System.Drawing.Point(7, 71);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(121, 21);
            this.RatingComboBox.TabIndex = 5;
            // 
            // ScheduleNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 379);
            this.Controls.Add(this.InsertLessonComboBox);
            this.Controls.Add(this.InsertScheduleComboBox);
            this.Name = "ScheduleNew";
            this.Text = "ScheduleNew";
            this.Load += new System.EventHandler(this.ScheduleNew_Load);
            this.InsertScheduleComboBox.ResumeLayout(false);
            this.InsertScheduleComboBox.PerformLayout();
            this.InsertLessonComboBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ScheduleTitleTextBox;
        private System.Windows.Forms.GroupBox InsertScheduleComboBox;
        private System.Windows.Forms.Button InsertSchedule;
        private System.Windows.Forms.GroupBox InsertLessonComboBox;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.Button LessonAddButton;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.ComboBox HourComboBox;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.RichTextBox CommentRichTextBox;
    }
}