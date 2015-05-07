namespace RunescapeHelper
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
            this.requestBtn = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.highscoreViewList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // requestBtn
            // 
            this.requestBtn.Location = new System.Drawing.Point(562, 863);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(136, 92);
            this.requestBtn.TabIndex = 1;
            this.requestBtn.Text = "Request";
            this.requestBtn.UseVisualStyleBackColor = true;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(237, 65);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(248, 26);
            this.usernameTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username :";
            // 
            // highscoreViewList
            // 
            this.highscoreViewList.Location = new System.Drawing.Point(34, 122);
            this.highscoreViewList.Name = "highscoreViewList";
            this.highscoreViewList.Size = new System.Drawing.Size(664, 709);
            this.highscoreViewList.TabIndex = 5;
            this.highscoreViewList.UseCompatibleStateImageBehavior = false;
            this.highscoreViewList.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 982);
            this.Controls.Add(this.highscoreViewList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.requestBtn);
            this.Name = "Form1";
            this.Text = "Runescape Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button requestBtn;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView highscoreViewList;
    }
}

