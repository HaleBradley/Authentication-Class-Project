namespace DatabaseFinal
{
    partial class EmployeeFrom
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
            this.payHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.personalInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.addressInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personalInfoEditButton = new System.Windows.Forms.Button();
            this.addressInformationEditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // payHistoryDataGridView
            // 
            this.payHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payHistoryDataGridView.Location = new System.Drawing.Point(205, 60);
            this.payHistoryDataGridView.Name = "payHistoryDataGridView";
            this.payHistoryDataGridView.RowHeadersWidth = 51;
            this.payHistoryDataGridView.RowTemplate.Height = 24;
            this.payHistoryDataGridView.Size = new System.Drawing.Size(825, 131);
            this.payHistoryDataGridView.TabIndex = 0;
            // 
            // personalInfoDataGridView
            // 
            this.personalInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalInfoDataGridView.Location = new System.Drawing.Point(205, 248);
            this.personalInfoDataGridView.Name = "personalInfoDataGridView";
            this.personalInfoDataGridView.RowHeadersWidth = 51;
            this.personalInfoDataGridView.Size = new System.Drawing.Size(825, 149);
            this.personalInfoDataGridView.TabIndex = 1;
            // 
            // addressInfoDataGridView
            // 
            this.addressInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressInfoDataGridView.Location = new System.Drawing.Point(205, 446);
            this.addressInfoDataGridView.Name = "addressInfoDataGridView";
            this.addressInfoDataGridView.RowHeadersWidth = 51;
            this.addressInfoDataGridView.Size = new System.Drawing.Size(825, 141);
            this.addressInfoDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pay History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personal Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address Information";
            // 
            // personalInfoEditButton
            // 
            this.personalInfoEditButton.Location = new System.Drawing.Point(57, 319);
            this.personalInfoEditButton.Name = "personalInfoEditButton";
            this.personalInfoEditButton.Size = new System.Drawing.Size(75, 23);
            this.personalInfoEditButton.TabIndex = 6;
            this.personalInfoEditButton.Text = "Edit";
            this.personalInfoEditButton.UseVisualStyleBackColor = true;
            this.personalInfoEditButton.Click += new System.EventHandler(this.personalInfoEditButton_Click);
            // 
            // addressInformationEditButton
            // 
            this.addressInformationEditButton.Location = new System.Drawing.Point(57, 524);
            this.addressInformationEditButton.Name = "addressInformationEditButton";
            this.addressInformationEditButton.Size = new System.Drawing.Size(75, 23);
            this.addressInformationEditButton.TabIndex = 7;
            this.addressInformationEditButton.Text = "Edit";
            this.addressInformationEditButton.UseVisualStyleBackColor = true;
            this.addressInformationEditButton.Click += new System.EventHandler(this.addressInformationEditButton_Click);
            // 
            // EmployeeFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 625);
            this.Controls.Add(this.addressInformationEditButton);
            this.Controls.Add(this.personalInfoEditButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressInfoDataGridView);
            this.Controls.Add(this.personalInfoDataGridView);
            this.Controls.Add(this.payHistoryDataGridView);
            this.Name = "EmployeeFrom";
            this.Text = "EmployeeFrom";
            this.Load += new System.EventHandler(this.EmployeeFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView payHistoryDataGridView;
        private System.Windows.Forms.DataGridView personalInfoDataGridView;
        private System.Windows.Forms.DataGridView addressInfoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button personalInfoEditButton;
        private System.Windows.Forms.Button addressInformationEditButton;
    }
}