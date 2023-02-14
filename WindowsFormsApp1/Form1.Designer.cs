namespace WindowsFormsApp1
{
    partial class Form1
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.conversaoLbl = new System.Windows.Forms.Label();
            this.conversaoCb = new System.Windows.Forms.ComboBox();
            this.valorConverterTxt = new System.Windows.Forms.TextBox();
            this.valorConvertidoTxt = new System.Windows.Forms.TextBox();
            this.valorConverterLbl = new System.Windows.Forms.Label();
            this.valorConvertidoLbl = new System.Windows.Forms.Label();
            this.converterBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titleLbl.Location = new System.Drawing.Point(222, 37);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(276, 24);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Conversor de Temperatura";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conversaoLbl
            // 
            this.conversaoLbl.AutoSize = true;
            this.conversaoLbl.Location = new System.Drawing.Point(15, 138);
            this.conversaoLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.conversaoLbl.Name = "conversaoLbl";
            this.conversaoLbl.Size = new System.Drawing.Size(120, 22);
            this.conversaoLbl.TabIndex = 1;
            this.conversaoLbl.Text = "Conversão:";
            this.conversaoLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.conversaoLbl.Click += new System.EventHandler(this.conversaolbl_Click);
            // 
            // conversaoCb
            // 
            this.conversaoCb.FormattingEnabled = true;
            this.conversaoCb.Items.AddRange(new object[] {
            "Celsius para Fahrenheit",
            "Fahrenheit para Celsius"});
            this.conversaoCb.Location = new System.Drawing.Point(144, 138);
            this.conversaoCb.Name = "conversaoCb";
            this.conversaoCb.Size = new System.Drawing.Size(275, 30);
            this.conversaoCb.TabIndex = 2;
            // 
            // valorConverterTxt
            // 
            this.valorConverterTxt.Location = new System.Drawing.Point(243, 233);
            this.valorConverterTxt.Name = "valorConverterTxt";
            this.valorConverterTxt.Size = new System.Drawing.Size(176, 30);
            this.valorConverterTxt.TabIndex = 3;
            this.valorConverterTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // valorConvertidoTxt
            // 
            this.valorConvertidoTxt.Location = new System.Drawing.Point(243, 317);
            this.valorConvertidoTxt.Name = "valorConvertidoTxt";
            this.valorConvertidoTxt.ReadOnly = true;
            this.valorConvertidoTxt.Size = new System.Drawing.Size(176, 30);
            this.valorConvertidoTxt.TabIndex = 4;
            // 
            // valorConverterLbl
            // 
            this.valorConverterLbl.AutoSize = true;
            this.valorConverterLbl.Location = new System.Drawing.Point(15, 233);
            this.valorConverterLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.valorConverterLbl.Name = "valorConverterLbl";
            this.valorConverterLbl.Size = new System.Drawing.Size(208, 22);
            this.valorConverterLbl.TabIndex = 5;
            this.valorConverterLbl.Text = "Valor a Converter:";
            this.valorConverterLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valorConvertidoLbl
            // 
            this.valorConvertidoLbl.AutoSize = true;
            this.valorConvertidoLbl.Location = new System.Drawing.Point(15, 317);
            this.valorConvertidoLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.valorConvertidoLbl.Name = "valorConvertidoLbl";
            this.valorConvertidoLbl.Size = new System.Drawing.Size(219, 22);
            this.valorConvertidoLbl.TabIndex = 6;
            this.valorConvertidoLbl.Text = "Valor a Convertido:";
            this.valorConvertidoLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // converterBtn
            // 
            this.converterBtn.Location = new System.Drawing.Point(548, 305);
            this.converterBtn.Name = "converterBtn";
            this.converterBtn.Size = new System.Drawing.Size(131, 51);
            this.converterBtn.TabIndex = 7;
            this.converterBtn.Text = "Converter";
            this.converterBtn.UseVisualStyleBackColor = true;
            this.converterBtn.Click += new System.EventHandler(this.converterBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Location = new System.Drawing.Point(548, 233);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(131, 51);
            this.limparBtn.TabIndex = 8;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 402);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.converterBtn);
            this.Controls.Add(this.valorConvertidoLbl);
            this.Controls.Add(this.valorConverterLbl);
            this.Controls.Add(this.valorConvertidoTxt);
            this.Controls.Add(this.valorConverterTxt);
            this.Controls.Add(this.conversaoCb);
            this.Controls.Add(this.conversaoLbl);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label conversaoLbl;
        private System.Windows.Forms.ComboBox conversaoCb;
        private System.Windows.Forms.TextBox valorConverterTxt;
        private System.Windows.Forms.TextBox valorConvertidoTxt;
        private System.Windows.Forms.Label valorConverterLbl;
        private System.Windows.Forms.Label valorConvertidoLbl;
        private System.Windows.Forms.Button converterBtn;
        private System.Windows.Forms.Button limparBtn;
    }
}

