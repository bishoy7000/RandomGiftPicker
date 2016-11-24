namespace GiftPicker
{
    partial class MainPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.SyncButton = new System.Windows.Forms.Button();
            this.syncDate = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.friends = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.syncLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SyncButton
            // 
            this.SyncButton.Location = new System.Drawing.Point(172, 308);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(75, 23);
            this.SyncButton.TabIndex = 1;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // syncDate
            // 
            this.syncDate.AutoSize = true;
            this.syncDate.Location = new System.Drawing.Point(225, 342);
            this.syncDate.Name = "syncDate";
            this.syncDate.Size = new System.Drawing.Size(83, 13);
            this.syncDate.TabIndex = 2;
            this.syncDate.Text = "Last Sync Date:";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(317, 308);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 3;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // friends
            // 
            this.friends.FormattingEnabled = true;
            this.friends.Location = new System.Drawing.Point(29, 51);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(120, 225);
            this.friends.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Friends wIth an anniversary in less than a week:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Gift You Friend!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // syncLabel
            // 
            this.syncLabel.AutoSize = true;
            this.syncLabel.Location = new System.Drawing.Point(314, 342);
            this.syncLabel.Name = "syncLabel";
            this.syncLabel.Size = new System.Drawing.Size(0, 13);
            this.syncLabel.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 364);
            this.Controls.Add(this.syncLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.friends);
            this.Controls.Add(this.close);
            this.Controls.Add(this.syncDate);
            this.Controls.Add(this.SyncButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPage";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.Label syncDate;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListBox friends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label syncLabel;
    }
}

