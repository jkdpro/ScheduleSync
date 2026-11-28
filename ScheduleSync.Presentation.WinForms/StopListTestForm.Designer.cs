namespace ScheduleSync.Presentation.WinForms
{
    partial class StopListTestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button retrieveStopsButton;
        private System.Windows.Forms.DataGridView stopsGrid;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.SplitContainer contentSplitContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.retrieveStopsButton = new System.Windows.Forms.Button();
            this.stopsGrid = new System.Windows.Forms.DataGridView();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.stopsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // retrieveStopsButton
            // 
            this.retrieveStopsButton.AutoSize = true;
            this.retrieveStopsButton.Location = new System.Drawing.Point(12, 12);
            this.retrieveStopsButton.Name = "retrieveStopsButton";
            this.retrieveStopsButton.Size = new System.Drawing.Size(140, 27);
            this.retrieveStopsButton.TabIndex = 0;
            this.retrieveStopsButton.Text = "Pobierz przystanki";
            this.retrieveStopsButton.UseVisualStyleBackColor = true;
            this.retrieveStopsButton.Click += new System.EventHandler(this.retrieveStopsButton_Click);
            // 
            // stopsGrid
            // 
            this.stopsGrid.AllowUserToAddRows = false;
            this.stopsGrid.AllowUserToDeleteRows = false;
            this.stopsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.stopsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stopsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopsGrid.Location = new System.Drawing.Point(0, 0);
            this.stopsGrid.Name = "stopsGrid";
            this.stopsGrid.ReadOnly = true;
            this.stopsGrid.RowHeadersVisible = false;
            this.stopsGrid.Size = new System.Drawing.Size(760, 238);
            this.stopsGrid.TabIndex = 0;
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(760, 116);
            this.logTextBox.TabIndex = 0;
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.contentSplitContainer.Location = new System.Drawing.Point(12, 52);
            this.contentSplitContainer.Name = "contentSplitContainer";
            this.contentSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.contentSplitContainer.Panel1.Controls.Add(this.stopsGrid);
            this.contentSplitContainer.Panel2.Controls.Add(this.logTextBox);
            this.contentSplitContainer.Size = new System.Drawing.Size(760, 358);
            this.contentSplitContainer.SplitterDistance = 238;
            this.contentSplitContainer.TabIndex = 1;
            // 
            // StopListTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 422);
            this.Controls.Add(this.contentSplitContainer);
            this.Controls.Add(this.retrieveStopsButton);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "StopListTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test pobierania przystanków";
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            this.contentSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stopsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
