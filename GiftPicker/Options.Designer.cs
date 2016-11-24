namespace GiftPicker
{
    partial class Options
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
            this.frListAdd = new System.Windows.Forms.Button();
            this.frAdd = new System.Windows.Forms.Button();
            this.giftListADD = new System.Windows.Forms.Button();
            this.giftAdd = new System.Windows.Forms.Button();
            this.giftAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frListAdd
            // 
            this.frListAdd.Location = new System.Drawing.Point(45, 13);
            this.frListAdd.Name = "frListAdd";
            this.frListAdd.Size = new System.Drawing.Size(90, 23);
            this.frListAdd.TabIndex = 0;
            this.frListAdd.Text = "Add Friend List";
            this.frListAdd.UseVisualStyleBackColor = true;
            this.frListAdd.Click += new System.EventHandler(this.frListAdd_Click);
            // 
            // frAdd
            // 
            this.frAdd.Location = new System.Drawing.Point(45, 55);
            this.frAdd.Name = "frAdd";
            this.frAdd.Size = new System.Drawing.Size(90, 23);
            this.frAdd.TabIndex = 1;
            this.frAdd.Text = "Add Friend";
            this.frAdd.UseVisualStyleBackColor = true;
            this.frAdd.Click += new System.EventHandler(this.frAdd_Click);
            // 
            // giftListADD
            // 
            this.giftListADD.Location = new System.Drawing.Point(217, 12);
            this.giftListADD.Name = "giftListADD";
            this.giftListADD.Size = new System.Drawing.Size(85, 23);
            this.giftListADD.TabIndex = 2;
            this.giftListADD.Text = "Add Gift List";
            this.giftListADD.UseVisualStyleBackColor = true;
            this.giftListADD.Click += new System.EventHandler(this.giftListADD_Click);
            // 
            // giftAdd
            // 
            this.giftAdd.Location = new System.Drawing.Point(216, 54);
            this.giftAdd.Name = "giftAdd";
            this.giftAdd.Size = new System.Drawing.Size(86, 23);
            this.giftAdd.TabIndex = 3;
            this.giftAdd.Text = "Add Gift";
            this.giftAdd.UseVisualStyleBackColor = true;
            this.giftAdd.Click += new System.EventHandler(this.giftAdd_Click);
            // 
            // giftAssign
            // 
            this.giftAssign.Location = new System.Drawing.Point(138, 98);
            this.giftAssign.Name = "giftAssign";
            this.giftAssign.Size = new System.Drawing.Size(75, 23);
            this.giftAssign.TabIndex = 4;
            this.giftAssign.Text = "Assign Gifts";
            this.giftAssign.UseVisualStyleBackColor = true;
            this.giftAssign.Click += new System.EventHandler(this.giftAssign_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 155);
            this.Controls.Add(this.giftAssign);
            this.Controls.Add(this.giftAdd);
            this.Controls.Add(this.giftListADD);
            this.Controls.Add(this.frAdd);
            this.Controls.Add(this.frListAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button frListAdd;
        private System.Windows.Forms.Button frAdd;
        private System.Windows.Forms.Button giftListADD;
        private System.Windows.Forms.Button giftAdd;
        private System.Windows.Forms.Button giftAssign;
    }
}