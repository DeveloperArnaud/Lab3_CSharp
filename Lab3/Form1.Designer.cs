namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.convertBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.labelEuro = new System.Windows.Forms.Label();
            this.textConvert = new System.Windows.Forms.TextBox();
            this.labelDh = new System.Windows.Forms.Label();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.radio_euroToDh = new System.Windows.Forms.RadioButton();
            this.radio_dhToEuro = new System.Windows.Forms.RadioButton();
            this.amountText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chargedText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(124, 241);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 0;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(316, 241);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Location = new System.Drawing.Point(121, 46);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(49, 13);
            this.labelEuro.TabIndex = 2;
            this.labelEuro.Text = "1 euro = ";
            // 
            // textConvert
            // 
            this.textConvert.Location = new System.Drawing.Point(176, 43);
            this.textConvert.Name = "textConvert";
            this.textConvert.Size = new System.Drawing.Size(189, 20);
            this.textConvert.TabIndex = 3;
            // 
            // labelDh
            // 
            this.labelDh.AutoSize = true;
            this.labelDh.Location = new System.Drawing.Point(371, 47);
            this.labelDh.Name = "labelDh";
            this.labelDh.Size = new System.Drawing.Size(19, 13);
            this.labelDh.TabIndex = 4;
            this.labelDh.Text = "dh";
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.radio_euroToDh);
            this.radioGroup.Controls.Add(this.radio_dhToEuro);
            this.radioGroup.Location = new System.Drawing.Point(176, 69);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(189, 100);
            this.radioGroup.TabIndex = 5;
            this.radioGroup.TabStop = false;
            this.radioGroup.Enter += new System.EventHandler(this.radioGroup_Enter);
            // 
            // radio_euroToDh
            // 
            this.radio_euroToDh.AutoSize = true;
            this.radio_euroToDh.Location = new System.Drawing.Point(98, 45);
            this.radio_euroToDh.Name = "radio_euroToDh";
            this.radio_euroToDh.Size = new System.Drawing.Size(90, 17);
            this.radio_euroToDh.TabIndex = 1;
            this.radio_euroToDh.TabStop = true;
            this.radio_euroToDh.Text = "EURO --> DH";
            this.radio_euroToDh.UseVisualStyleBackColor = true;
            this.radio_euroToDh.CheckedChanged += new System.EventHandler(this.radio_euroToDh_CheckedChanged);
            // 
            // radio_dhToEuro
            // 
            this.radio_dhToEuro.AutoSize = true;
            this.radio_dhToEuro.Location = new System.Drawing.Point(6, 45);
            this.radio_dhToEuro.Name = "radio_dhToEuro";
            this.radio_dhToEuro.Size = new System.Drawing.Size(90, 17);
            this.radio_dhToEuro.TabIndex = 0;
            this.radio_dhToEuro.TabStop = true;
            this.radio_dhToEuro.Text = "DH --> EURO";
            this.radio_dhToEuro.UseVisualStyleBackColor = true;
            this.radio_dhToEuro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(176, 175);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(189, 20);
            this.amountText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // chargedText
            // 
            this.chargedText.Location = new System.Drawing.Point(176, 201);
            this.chargedText.Name = "chargedText";
            this.chargedText.Size = new System.Drawing.Size(189, 20);
            this.chargedText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Changed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 299);
            this.Controls.Add(this.chargedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.labelDh);
            this.Controls.Add(this.textConvert);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.convertBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.TextBox textConvert;
        private System.Windows.Forms.Label labelDh;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.RadioButton radio_euroToDh;
        private System.Windows.Forms.RadioButton radio_dhToEuro;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chargedText;
        private System.Windows.Forms.Label label4;
    }
}

