namespace Topic_11___Input_with_GUI_s
{
    partial class FormInput
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(408, 142);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(408, 168);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(408, 116);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 2;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(269, 119);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(86, 13);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Enter item name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(269, 145);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Enter a price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(269, 171);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(86, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Number of items:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(269, 265);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(59, 13);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "Final Price:";
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(297, 216);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(190, 23);
            this.btnCalculatePrice.TabIndex = 7;
            this.btnCalculatePrice.Text = "Calculate Final Price";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculatePrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Name = "FormInput";
            this.Text = "User Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnCalculatePrice;
    }
}

