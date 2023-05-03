namespace Kliensalkalmazás
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ModifyPriceButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ModifyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(257, 43);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 33;
            this.DataGridView.Size = new System.Drawing.Size(531, 355);
            this.DataGridView.TabIndex = 0;
            // 
            // ModifyPriceButton
            // 
            this.ModifyPriceButton.Location = new System.Drawing.Point(26, 149);
            this.ModifyPriceButton.Name = "ModifyPriceButton";
            this.ModifyPriceButton.Size = new System.Drawing.Size(182, 34);
            this.ModifyPriceButton.TabIndex = 1;
            this.ModifyPriceButton.Text = "Modify Price";
            this.ModifyPriceButton.UseVisualStyleBackColor = true;
            this.ModifyPriceButton.Click += new System.EventHandler(this.ModifyPriceButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(26, 248);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(182, 34);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete Product";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ModifyTextBox
            // 
            this.ModifyTextBox.Location = new System.Drawing.Point(54, 112);
            this.ModifyTextBox.Name = "ModifyTextBox";
            this.ModifyTextBox.Size = new System.Drawing.Size(121, 31);
            this.ModifyTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModifyTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyPriceButton);
            this.Controls.Add(this.DataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGridView;
        private Button ModifyPriceButton;
        private Button DeleteButton;
        private TextBox ModifyTextBox;
    }
}