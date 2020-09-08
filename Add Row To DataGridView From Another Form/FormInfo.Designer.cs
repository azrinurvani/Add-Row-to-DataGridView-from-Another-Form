namespace Add_Row_To_DataGridView_From_Another_Form
{
    partial class FormInfo
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
            this.labelID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboID = new System.Windows.Forms.TextBox();
            this.tboFirstName = new System.Windows.Forms.TextBox();
            this.tboLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(72, 39);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(29, 17);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name :";
            // 
            // tboID
            // 
            this.tboID.Location = new System.Drawing.Point(136, 39);
            this.tboID.Name = "tboID";
            this.tboID.Size = new System.Drawing.Size(144, 23);
            this.tboID.TabIndex = 4;
            // 
            // tboFirstName
            // 
            this.tboFirstName.Location = new System.Drawing.Point(136, 85);
            this.tboFirstName.Name = "tboFirstName";
            this.tboFirstName.Size = new System.Drawing.Size(144, 23);
            this.tboFirstName.TabIndex = 5;
            // 
            // tboLastName
            // 
            this.tboLastName.Location = new System.Drawing.Point(136, 128);
            this.tboLastName.Name = "tboLastName";
            this.tboLastName.Size = new System.Drawing.Size(144, 23);
            this.tboLastName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 294);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboLastName);
            this.Controls.Add(this.tboFirstName);
            this.Controls.Add(this.tboID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInfo";
            this.Text = "Form Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboID;
        private System.Windows.Forms.TextBox tboFirstName;
        private System.Windows.Forms.TextBox tboLastName;
        private System.Windows.Forms.Button btnAdd;
    }
}