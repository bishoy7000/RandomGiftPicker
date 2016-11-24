namespace GiftPicker.OptionsForms
{
    partial class AssignGifts
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
            this.assign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frList = new System.Windows.Forms.ComboBox();
            this.giftList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // assign
            // 
            this.assign.Location = new System.Drawing.Point(107, 169);
            this.assign.Name = "assign";
            this.assign.Size = new System.Drawing.Size(75, 23);
            this.assign.TabIndex = 0;
            this.assign.Text = "Assign";
            this.assign.UseVisualStyleBackColor = true;
            this.assign.Click += new System.EventHandler(this.assign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Friend List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gift List";
            // 
            // frList
            // 
            this.frList.FormattingEnabled = true;
            this.frList.Location = new System.Drawing.Point(96, 51);
            this.frList.Name = "frList";
            this.frList.Size = new System.Drawing.Size(121, 21);
            this.frList.TabIndex = 3;
            this.frList.SelectedIndexChanged += new System.EventHandler(this.frList_SelectedIndexChanged);
            // 
            // giftList
            // 
            this.giftList.FormattingEnabled = true;
            this.giftList.Location = new System.Drawing.Point(96, 102);
            this.giftList.Name = "giftList";
            this.giftList.Size = new System.Drawing.Size(121, 21);
            this.giftList.TabIndex = 4;
            // 
            // AssignGifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.giftList);
            this.Controls.Add(this.frList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assign);
            this.Name = "AssignGifts";
            this.Text = "AssignGifts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox frList;
        private System.Windows.Forms.ComboBox giftList;
    }
}