namespace Lab3
{
    partial class Form2
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
            this.txt_basePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_typeTicket = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_priceHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_priceTTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.reduction_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Price: ";
            // 
            // txt_basePrice
            // 
            this.txt_basePrice.Location = new System.Drawing.Point(118, 34);
            this.txt_basePrice.Name = "txt_basePrice";
            this.txt_basePrice.Size = new System.Drawing.Size(204, 20);
            this.txt_basePrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type of ticket :";
            // 
            // lb_typeTicket
            // 
            this.lb_typeTicket.FormattingEnabled = true;
            this.lb_typeTicket.Location = new System.Drawing.Point(118, 70);
            this.lb_typeTicket.Name = "lb_typeTicket";
            this.lb_typeTicket.Size = new System.Drawing.Size(204, 30);
            this.lb_typeTicket.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reduction";
            // 
            // txt_priceHT
            // 
            this.txt_priceHT.Location = new System.Drawing.Point(118, 196);
            this.txt_priceHT.Name = "txt_priceHT";
            this.txt_priceHT.Size = new System.Drawing.Size(204, 20);
            this.txt_priceHT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price HT: ";
            // 
            // txt_tva
            // 
            this.txt_tva.Location = new System.Drawing.Point(118, 231);
            this.txt_tva.Name = "txt_tva";
            this.txt_tva.Size = new System.Drawing.Size(204, 20);
            this.txt_tva.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TVA: ";
            // 
            // txt_priceTTC
            // 
            this.txt_priceTTC.Location = new System.Drawing.Point(118, 269);
            this.txt_priceTTC.Name = "txt_priceTTC";
            this.txt_priceTTC.Size = new System.Drawing.Size(204, 20);
            this.txt_priceTTC.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price TTC: ";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(118, 339);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(164, 23);
            this.calculateBtn.TabIndex = 12;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(118, 368);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(164, 23);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Reintialize";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(118, 397);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(164, 23);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // reduction_cb
            // 
            this.reduction_cb.FormattingEnabled = true;
            this.reduction_cb.Location = new System.Drawing.Point(118, 119);
            this.reduction_cb.Name = "reduction_cb";
            this.reduction_cb.Size = new System.Drawing.Size(204, 21);
            this.reduction_cb.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.reduction_cb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.txt_priceTTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_priceHT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_typeTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_basePrice);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_basePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_typeTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_priceHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_priceTTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ComboBox reduction_cb;
    }
}