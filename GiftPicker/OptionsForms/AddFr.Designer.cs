namespace GiftPicker.OptionsForms
{
    partial class AddFr
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
            this.label2 = new System.Windows.Forms.Label();
            this.frName = new System.Windows.Forms.TextBox();
            this.aniverDate = new System.Windows.Forms.DateTimePicker();
            this.frList = new System.Windows.Forms.ComboBox();
            this.frLists = new System.Windows.Forms.Label();
            this.addFrbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Friend Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aniversary Date:";
            // 
            // frName
            // 
            this.frName.Location = new System.Drawing.Point(115, 49);
            this.frName.Name = "frName";
            this.frName.Size = new System.Drawing.Size(100, 20);
            this.frName.TabIndex = 2;
            // 
            // aniverDate
            // 
            this.aniverDate.CustomFormat = "yyyy-MM-dd";
            this.aniverDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.aniverDate.Location = new System.Drawing.Point(115, 113);
            this.aniverDate.Name = "aniverDate";
            this.aniverDate.Size = new System.Drawing.Size(100, 20);
            this.aniverDate.TabIndex = 3;
            // 
            // frList
            // 
            this.frList.FormattingEnabled = true;
            this.frList.Location = new System.Drawing.Point(115, 184);
            this.frList.Name = "frList";
            this.frList.Size = new System.Drawing.Size(100, 21);
            this.frList.TabIndex = 4;
            // 
            // frLists
            // 
            this.frLists.AutoSize = true;
            this.frLists.Location = new System.Drawing.Point(15, 187);
            this.frLists.Name = "frLists";
            this.frLists.Size = new System.Drawing.Size(60, 13);
            this.frLists.TabIndex = 5;
            this.frLists.Text = "Friend Lists";
            // 
            // addFrbutton
            // 
            this.addFrbutton.Location = new System.Drawing.Point(140, 244);
            this.addFrbutton.Name = "addFrbutton";
            this.addFrbutton.Size = new System.Drawing.Size(75, 23);
            this.addFrbutton.TabIndex = 6;
            this.addFrbutton.Text = "Add";
            this.addFrbutton.UseVisualStyleBackColor = true;
            this.addFrbutton.Click += new System.EventHandler(this.addFrbutton_Click);
            // 
            // AddFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 291);
            this.Controls.Add(this.addFrbutton);
            this.Controls.Add(this.frLists);
            this.Controls.Add(this.frList);
            this.Controls.Add(this.aniverDate);
            this.Controls.Add(this.frName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddFr";
            this.Text = "Add Friend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frName;
        private System.Windows.Forms.DateTimePicker aniverDate;
        private System.Windows.Forms.ComboBox frList;
        private System.Windows.Forms.Label frLists;
        private System.Windows.Forms.Button addFrbutton;
    }
}