namespace Corretora_de_Investimento
{
    partial class SingOnScreen
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
            this.buttonSingOn = new System.Windows.Forms.Button();
            this.labelSingOn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.linkLabelSingOn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonSingOn
            // 
            this.buttonSingOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.buttonSingOn.FlatAppearance.BorderSize = 0;
            this.buttonSingOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingOn.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSingOn.Location = new System.Drawing.Point(356, 295);
            this.buttonSingOn.Name = "buttonSingOn";
            this.buttonSingOn.Size = new System.Drawing.Size(105, 45);
            this.buttonSingOn.TabIndex = 5;
            this.buttonSingOn.Text = "Registrar";
            this.buttonSingOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSingOn.UseVisualStyleBackColor = false;
            this.buttonSingOn.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelSingOn
            // 
            this.labelSingOn.AutoSize = true;
            this.labelSingOn.BackColor = System.Drawing.Color.Transparent;
            this.labelSingOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSingOn.ForeColor = System.Drawing.Color.White;
            this.labelSingOn.Location = new System.Drawing.Point(341, 71);
            this.labelSingOn.Name = "labelSingOn";
            this.labelSingOn.Size = new System.Drawing.Size(134, 33);
            this.labelSingOn.TabIndex = 6;
            this.labelSingOn.Text = "Registrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(294, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Já tem uma conta?";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(378, 220);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 20);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Senha:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(374, 143);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(68, 20);
            this.UserNameLabel.TabIndex = 9;
            this.UserNameLabel.Text = "Usuário:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.White;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(251, 175);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(315, 26);
            this.UserNameTextBox.TabIndex = 8;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(251, 247);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(315, 26);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // linkLabelSingOn
            // 
            this.linkLabelSingOn.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelSingOn.AutoSize = true;
            this.linkLabelSingOn.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSingOn.DisabledLinkColor = System.Drawing.Color.Silver;
            this.linkLabelSingOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSingOn.LinkColor = System.Drawing.Color.White;
            this.linkLabelSingOn.Location = new System.Drawing.Point(436, 383);
            this.linkLabelSingOn.Name = "linkLabelSingOn";
            this.linkLabelSingOn.Size = new System.Drawing.Size(92, 20);
            this.linkLabelSingOn.TabIndex = 12;
            this.linkLabelSingOn.TabStop = true;
            this.linkLabelSingOn.Text = "Faça Login!";
            this.linkLabelSingOn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSingOn_LinkClicked);
            // 
            // SingOnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.BackgroundImage = global::Corretora_de_Investimento.Properties.Resources.Projeto_Final_Matheus_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelSingOn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.labelSingOn);
            this.Controls.Add(this.buttonSingOn);
            this.Name = "SingOnScreen";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSingOn;
        private System.Windows.Forms.Label labelSingOn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.LinkLabel linkLabelSingOn;
    }
}