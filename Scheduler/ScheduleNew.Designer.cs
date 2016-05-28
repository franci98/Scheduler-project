﻿namespace Scheduler.Forms
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
            this.DayComboBox = new System.Windows.Forms.ComboBox();
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
            this.InsertLessonComboBox.Controls.Add(this.DayComboBox);
            this.InsertLessonComboBox.Location = new System.Drawing.Point(13, 75);
            this.InsertLessonComboBox.Name = "InsertLessonComboBox";
            this.InsertLessonComboBox.Size = new System.Drawing.Size(517, 57);
            this.InsertLessonComboBox.TabIndex = 2;
            this.InsertLessonComboBox.TabStop = false;
            this.InsertLessonComboBox.Text = "Dodaj šolsko uro";
            this.InsertLessonComboBox.Visible = false;
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
            // ScheduleNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 379);
            this.Controls.Add(this.InsertLessonComboBox);
            this.Controls.Add(this.InsertScheduleComboBox);
            this.Name = "ScheduleNew";
            this.Text = "ScheduleNew";
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
    }
}