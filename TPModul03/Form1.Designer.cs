namespace TPModul03
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
            this.inputName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.outputName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(40, 37);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(216, 26);
            this.inputName.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(284, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 26);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Kirim";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // outputName
            // 
            this.outputName.AutoSize = true;
            this.outputName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.outputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputName.Location = new System.Drawing.Point(46, 82);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(58, 20);
            this.outputName.TabIndex = 2;
            this.outputName.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 174);
            this.Controls.Add(this.outputName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.inputName);
            this.Name = "Form1";
            this.Text = "TP Modul 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label outputName;
    }
}

