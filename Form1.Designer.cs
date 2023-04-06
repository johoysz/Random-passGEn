namespace RandomPasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userInput = new System.Windows.Forms.Label();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.randomPass = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.genPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.AutoSize = true;
            this.userInput.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userInput.Location = new System.Drawing.Point(12, 56);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(94, 19);
            this.userInput.TabIndex = 0;
            this.userInput.Text = "User Input:";
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserInput.Location = new System.Drawing.Point(112, 53);
            this.textBoxUserInput.Multiline = true;
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(183, 27);
            this.textBoxUserInput.TabIndex = 1;
            this.textBoxUserInput.TabStop = false;
            // 
            // randomPass
            // 
            this.randomPass.AutoSize = true;
            this.randomPass.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.randomPass.Location = new System.Drawing.Point(12, 108);
            this.randomPass.Name = "randomPass";
            this.randomPass.Size = new System.Drawing.Size(94, 19);
            this.randomPass.TabIndex = 2;
            this.randomPass.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(112, 100);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(183, 27);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TabStop = false;
            // 
            // genPassButton
            // 
            this.genPassButton.BackColor = System.Drawing.Color.Goldenrod;
            this.genPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genPassButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genPassButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.genPassButton.Location = new System.Drawing.Point(65, 170);
            this.genPassButton.Name = "genPassButton";
            this.genPassButton.Size = new System.Drawing.Size(189, 47);
            this.genPassButton.TabIndex = 4;
            this.genPassButton.Text = "Generate Password";
            this.genPassButton.UseVisualStyleBackColor = false;
            this.genPassButton.Click += new System.EventHandler(this.genPassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(316, 250);
            this.Controls.Add(this.genPassButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.randomPass);
            this.Controls.Add(this.textBoxUserInput);
            this.Controls.Add(this.userInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userInput;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Label randomPass;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button genPassButton;
    }
}

