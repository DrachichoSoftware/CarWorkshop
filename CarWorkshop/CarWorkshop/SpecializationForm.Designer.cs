namespace CarWorkshop
{
    partial class SpecializationForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.specializationDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.specializationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(256, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // specializationDataGridView
            // 
            this.specializationDataGridView.AllowUserToAddRows = false;
            this.specializationDataGridView.AllowUserToDeleteRows = false;
            this.specializationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specializationDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.specializationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.specializationDataGridView.Name = "specializationDataGridView";
            this.specializationDataGridView.ReadOnly = true;
            this.specializationDataGridView.Size = new System.Drawing.Size(587, 220);
            this.specializationDataGridView.TabIndex = 1;
            // 
            // SpecializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 261);
            this.Controls.Add(this.specializationDataGridView);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpecializationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Специализации";
            this.Load += new System.EventHandler(this.SpecializationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specializationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView specializationDataGridView;
    }
}