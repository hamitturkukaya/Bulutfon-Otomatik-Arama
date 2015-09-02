namespace OtomatikArama
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.callPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.makeCallButton = new System.Windows.Forms.Button();
            this.txtReceivers = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.announcementCombo = new System.Windows.Forms.ComboBox();
            this.didCombo = new System.Windows.Forms.ComboBox();
            this.callPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(218, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // callPanel
            // 
            this.callPanel.Controls.Add(this.didCombo);
            this.callPanel.Controls.Add(this.announcementCombo);
            this.callPanel.Controls.Add(this.label4);
            this.callPanel.Controls.Add(this.label3);
            this.callPanel.Controls.Add(this.label2);
            this.callPanel.Controls.Add(this.label1);
            this.callPanel.Controls.Add(this.makeCallButton);
            this.callPanel.Controls.Add(this.txtReceivers);
            this.callPanel.Controls.Add(this.txtTitle);
            this.callPanel.Location = new System.Drawing.Point(77, 41);
            this.callPanel.Name = "callPanel";
            this.callPanel.Size = new System.Drawing.Size(347, 205);
            this.callPanel.TabIndex = 1;
            this.callPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Başlık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Çalınacak Ses Kaydı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aranacak Numaralar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arayan Numara";
            // 
            // makeCallButton
            // 
            this.makeCallButton.Location = new System.Drawing.Point(118, 171);
            this.makeCallButton.Name = "makeCallButton";
            this.makeCallButton.Size = new System.Drawing.Size(75, 23);
            this.makeCallButton.TabIndex = 4;
            this.makeCallButton.Text = "Arama Yap";
            this.makeCallButton.UseVisualStyleBackColor = true;
            this.makeCallButton.Click += new System.EventHandler(this.makeCallButton_Click);
            // 
            // txtReceivers
            // 
            this.txtReceivers.Location = new System.Drawing.Point(141, 97);
            this.txtReceivers.Name = "txtReceivers";
            this.txtReceivers.Size = new System.Drawing.Size(160, 20);
            this.txtReceivers.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(141, 17);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // announcementCombo
            // 
            this.announcementCombo.FormattingEnabled = true;
            this.announcementCombo.Location = new System.Drawing.Point(141, 132);
            this.announcementCombo.Name = "announcementCombo";
            this.announcementCombo.Size = new System.Drawing.Size(160, 21);
            this.announcementCombo.TabIndex = 9;
            // 
            // didCombo
            // 
            this.didCombo.FormattingEnabled = true;
            this.didCombo.Location = new System.Drawing.Point(141, 57);
            this.didCombo.Name = "didCombo";
            this.didCombo.Size = new System.Drawing.Size(160, 21);
            this.didCombo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 302);
            this.Controls.Add(this.callPanel);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.callPanel.ResumeLayout(false);
            this.callPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel callPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button makeCallButton;
        private System.Windows.Forms.TextBox txtReceivers;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox announcementCombo;
        private System.Windows.Forms.ComboBox didCombo;
    }
}

