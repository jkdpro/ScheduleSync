namespace ScheduleSync.Presentation.WinForms
{
    partial class MainForm
    {
        private System.Windows.Forms.Button openStopsTestButton;

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
            this.openStopsTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openStopsTestButton
            // 
            this.openStopsTestButton.AutoSize = true;
            this.openStopsTestButton.Location = new System.Drawing.Point(24, 24);
            this.openStopsTestButton.Name = "openStopsTestButton";
            this.openStopsTestButton.Size = new System.Drawing.Size(176, 27);
            this.openStopsTestButton.TabIndex = 0;
            this.openStopsTestButton.Text = "Test pobierania przystanków";
            this.openStopsTestButton.UseVisualStyleBackColor = true;
            this.openStopsTestButton.Click += new System.EventHandler(this.openStopsTestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openStopsTestButton);
            this.Name = "MainForm";
            this.Text = "ScheduleSync";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}


