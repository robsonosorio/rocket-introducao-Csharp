namespace SimplePaint
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonBorracha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEspessuraDaCaneta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCorCaneta = new System.Windows.Forms.Button();
            this.panelPintura = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonBorracha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEspessuraDaCaneta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCorCaneta);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personalizar";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(701, 39);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(102, 31);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(809, 39);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(97, 31);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonBorracha
            // 
            this.buttonBorracha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBorracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorracha.Location = new System.Drawing.Point(576, 39);
            this.buttonBorracha.Name = "buttonBorracha";
            this.buttonBorracha.Size = new System.Drawing.Size(119, 31);
            this.buttonBorracha.TabIndex = 4;
            this.buttonBorracha.Text = "Borracha";
            this.buttonBorracha.UseVisualStyleBackColor = false;
            this.buttonBorracha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBorracha_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Espessura da Caneta";
            // 
            // comboBoxEspessuraDaCaneta
            // 
            this.comboBoxEspessuraDaCaneta.FormattingEnabled = true;
            this.comboBoxEspessuraDaCaneta.Location = new System.Drawing.Point(457, 39);
            this.comboBoxEspessuraDaCaneta.Name = "comboBoxEspessuraDaCaneta";
            this.comboBoxEspessuraDaCaneta.Size = new System.Drawing.Size(113, 31);
            this.comboBoxEspessuraDaCaneta.TabIndex = 2;
            this.comboBoxEspessuraDaCaneta.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspessuraDaCaneta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cor da Caneta";
            // 
            // buttonCorCaneta
            // 
            this.buttonCorCaneta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCorCaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorCaneta.Location = new System.Drawing.Point(162, 39);
            this.buttonCorCaneta.Name = "buttonCorCaneta";
            this.buttonCorCaneta.Size = new System.Drawing.Size(75, 31);
            this.buttonCorCaneta.TabIndex = 0;
            this.buttonCorCaneta.UseVisualStyleBackColor = false;
            this.buttonCorCaneta.Click += new System.EventHandler(this.buttonCorCaneta_Click);
            // 
            // panelPintura
            // 
            this.panelPintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPintura.BackColor = System.Drawing.Color.White;
            this.panelPintura.Location = new System.Drawing.Point(12, 142);
            this.panelPintura.Name = "panelPintura";
            this.panelPintura.Size = new System.Drawing.Size(918, 329);
            this.panelPintura.TabIndex = 1;
            this.panelPintura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseDown);
            this.panelPintura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseMove);
            this.panelPintura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseUp);
            this.panelPintura.Resize += new System.EventHandler(this.panelPintura_Resize);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(955, 499);
            this.Controls.Add(this.panelPintura);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Simple Paint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonBorracha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEspessuraDaCaneta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCorCaneta;
        private System.Windows.Forms.Panel panelPintura;
    }
}

