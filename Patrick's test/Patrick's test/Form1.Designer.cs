namespace Patrick_s_test
{
    partial class HelloWorld
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
            this.lblCopy = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCopy
            // 
            this.lblCopy.Location = new System.Drawing.Point(245, 42);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(156, 20);
            this.lblCopy.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCopy
            // 
            this.txtCopy.Location = new System.Drawing.Point(219, 119);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(166, 22);
            this.txtCopy.TabIndex = 2;
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 559);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCopy);
            this.Name = "HelloWorld";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCopy;
    }
}

