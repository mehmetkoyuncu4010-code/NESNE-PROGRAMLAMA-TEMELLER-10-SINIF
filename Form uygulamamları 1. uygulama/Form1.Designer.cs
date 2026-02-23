namespace Form_uygulamamları_1.uygulama
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnControlBox = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(65, 43);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(118, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept ";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(65, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnControlBox
            // 
            this.btnControlBox.Location = new System.Drawing.Point(65, 102);
            this.btnControlBox.Name = "btnControlBox";
            this.btnControlBox.Size = new System.Drawing.Size(118, 24);
            this.btnControlBox.TabIndex = 2;
            this.btnControlBox.Text = "ControlBox ";
            this.btnControlBox.UseVisualStyleBackColor = true;
            this.btnControlBox.Click += new System.EventHandler(this.btnControlBox_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(67, 132);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(116, 23);
            this.btnCenter.TabIndex = 3;
            this.btnCenter.Text = "Center To Screen";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(65, 161);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(118, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show ";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(65, 190);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(118, 23);
            this.btnDialog.TabIndex = 5;
            this.btnDialog.Text = "Show Dialog ";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnDialog);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnControlBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnControlBox;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDialog;
    }
}

