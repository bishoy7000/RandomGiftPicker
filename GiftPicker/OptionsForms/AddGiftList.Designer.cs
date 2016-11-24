namespace GiftPicker.OptionsForms
{
    partial class AddGiftList
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
            this.giftListAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.giftListName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // giftListAdd
            // 
            this.giftListAdd.Location = new System.Drawing.Point(94, 121);
            this.giftListAdd.Name = "giftListAdd";
            this.giftListAdd.Size = new System.Drawing.Size(75, 23);
            this.giftListAdd.TabIndex = 0;
            this.giftListAdd.Text = "Add";
            this.giftListAdd.UseVisualStyleBackColor = true;
            this.giftListAdd.Click += new System.EventHandler(this.giftListAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gift List Name:";
            // 
            // giftListName
            // 
            this.giftListName.Location = new System.Drawing.Point(109, 60);
            this.giftListName.Name = "giftListName";
            this.giftListName.Size = new System.Drawing.Size(100, 20);
            this.giftListName.TabIndex = 2;
            // 
            // AddGiftList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 178);
            this.Controls.Add(this.giftListName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giftListAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddGiftList";
            this.Text = "AddGiftList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giftListAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox giftListName;
    }
}