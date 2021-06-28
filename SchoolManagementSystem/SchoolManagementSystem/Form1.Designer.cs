
namespace SchoolManagementSystem
{
    partial class Form1
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
            this.labelProcessing = new System.Windows.Forms.Label();
            this.viewParent = new System.Windows.Forms.Button();
            this.dgvdetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProcessing
            // 
            this.labelProcessing.AutoSize = true;
            this.labelProcessing.Location = new System.Drawing.Point(37, 412);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(46, 17);
            this.labelProcessing.TabIndex = 0;
            this.labelProcessing.Text = "label1";
            // 
            // viewParent
            // 
            this.viewParent.Location = new System.Drawing.Point(31, 129);
            this.viewParent.Name = "viewParent";
            this.viewParent.Size = new System.Drawing.Size(181, 40);
            this.viewParent.TabIndex = 1;
            this.viewParent.Text = "View Parent Detail";
            this.viewParent.UseVisualStyleBackColor = true;
            this.viewParent.Click += new System.EventHandler(this.viewParent_Click);
            // 
            // dgvdetail
            // 
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetail.Location = new System.Drawing.Point(31, 201);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.RowHeadersWidth = 51;
            this.dgvdetail.RowTemplate.Height = 24;
            this.dgvdetail.Size = new System.Drawing.Size(745, 181);
            this.dgvdetail.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvdetail);
            this.Controls.Add(this.viewParent);
            this.Controls.Add(this.labelProcessing);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProcessing;
        private System.Windows.Forms.Button viewParent;
        private System.Windows.Forms.DataGridView dgvdetail;
    }
}