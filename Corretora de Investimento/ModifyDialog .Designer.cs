namespace Corretora_de_Investimento
{
    partial class ModifyDialog
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
            this.TextTableName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.attributeBox1 = new System.Windows.Forms.GroupBox();
            this.attributeTextBox1 = new System.Windows.Forms.TextBox();
            this.attributeBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextModify
            // 
            this.TextModify.AutoSize = true;
            this.TextModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextModify.ForeColor = System.Drawing.SystemColors.Control;
            this.TextModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextModify.Location = new System.Drawing.Point(55, 53);
            this.TextModify.Name = "TextModify";
            this.TextModify.Size = new System.Drawing.Size(186, 24);
            this.TextModify.TabIndex = 0;
            this.TextModify.Text = "Modificar elemento - ";
            // 
            // TextTableName
            // 
            this.TextTableName.AutoSize = true;
            this.TextTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextTableName.ForeColor = System.Drawing.SystemColors.Control;
            this.TextTableName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextTableName.Location = new System.Drawing.Point(231, 53);
            this.TextTableName.Name = "TextTableName";
            this.TextTableName.Size = new System.Drawing.Size(95, 24);
            this.TextTableName.TabIndex = 1;
            this.TextTableName.Text = "undefined";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Image = global::Corretora_de_Investimento.Properties.Resources.cross_symbol;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(251, 700);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 45);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConfirm.Image = global::Corretora_de_Investimento.Properties.Resources.check_symbol;
            this.buttonConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonConfirm.Location = new System.Drawing.Point(131, 700);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(105, 45);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // attributeBox1
            // 
            this.attributeBox1.Controls.Add(this.attributeTextBox1);
            this.attributeBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.attributeBox1.Location = new System.Drawing.Point(59, 109);
            this.attributeBox1.Name = "attributeBox1";
            this.attributeBox1.Size = new System.Drawing.Size(361, 50);
            this.attributeBox1.TabIndex = 9;
            this.attributeBox1.TabStop = false;
            this.attributeBox1.Text = "Attribute Name";
            // 
            // attributeTextBox1
            // 
            this.attributeTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.attributeTextBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.attributeTextBox1.Location = new System.Drawing.Point(6, 18);
            this.attributeTextBox1.Name = "attributeTextBox1";
            this.attributeTextBox1.Size = new System.Drawing.Size(349, 22);
            this.attributeTextBox1.TabIndex = 0;
            // 
            // ModifyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(480, 783);
            this.Controls.Add(this.attributeBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.TextTableName);
            this.Controls.Add(this.TextModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar elemento";
            this.attributeBox1.ResumeLayout(false);
            this.attributeBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextModify;
        private System.Windows.Forms.Label TextTableName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox attributeBox1;
        private System.Windows.Forms.TextBox attributeTextBox1;
    }
}