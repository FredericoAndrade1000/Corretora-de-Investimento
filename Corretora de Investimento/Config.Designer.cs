namespace Corretora_de_Investimento
{
    partial class Config
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
            this.TextModify = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextModify
            // 
            this.TextModify.AllowDrop = true;
            this.TextModify.AutoSize = true;
            this.TextModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextModify.ForeColor = System.Drawing.SystemColors.Control;
            this.TextModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextModify.Location = new System.Drawing.Point(114, 53);
            this.TextModify.Name = "TextModify";
            this.TextModify.Size = new System.Drawing.Size(132, 24);
            this.TextModify.TabIndex = 1;
            this.TextModify.Text = "Configurações";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Português",
            "Inglês"});
            this.LanguageComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LanguageComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.LanguageComboBox.Location = new System.Drawing.Point(59, 128);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(162, 21);
            this.LanguageComboBox.TabIndex = 2;
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Image = global::Corretora_de_Investimento.Properties.Resources.exit;
            this.buttonLogOut.Location = new System.Drawing.Point(59, 183);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(37, 35);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AllowDrop = true;
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLanguage.Location = new System.Drawing.Point(56, 100);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(74, 16);
            this.labelLanguage.TabIndex = 4;
            this.labelLanguage.Text = "Linguagem";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(345, 245);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.TextModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Text = "Configurações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextModify;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelLanguage;
    }
}