namespace QLSV_LinQ
{
    partial class GetMSSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGetMssv = new System.Windows.Forms.TextBox();
            this.btnOKE = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập MSSV: ";
            // 
            // txtGetMssv
            // 
            this.txtGetMssv.Location = new System.Drawing.Point(178, 51);
            this.txtGetMssv.Name = "txtGetMssv";
            this.txtGetMssv.Size = new System.Drawing.Size(300, 22);
            this.txtGetMssv.TabIndex = 1;
            // 
            // btnOKE
            // 
            this.btnOKE.Location = new System.Drawing.Point(194, 102);
            this.btnOKE.Name = "btnOKE";
            this.btnOKE.Size = new System.Drawing.Size(98, 46);
            this.btnOKE.TabIndex = 2;
            this.btnOKE.Text = "OK";
            this.btnOKE.UseVisualStyleBackColor = true;
            this.btnOKE.Click += new System.EventHandler(this.btnOKE_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 46);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GetMSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 178);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOKE);
            this.Controls.Add(this.txtGetMssv);
            this.Controls.Add(this.label1);
            this.Name = "GetMSSV";
            this.Text = "GetMSSV";
            this.Load += new System.EventHandler(this.GetMSSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGetMssv;
        private System.Windows.Forms.Button btnOKE;
        private System.Windows.Forms.Button btnCancel;
    }
}