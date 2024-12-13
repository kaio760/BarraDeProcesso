namespace barra_de_processo___1
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
            rtb_numero = new RichTextBox();
            mtb_numeric = new MaskedTextBox();
            lbl_numero = new Label();
            but_ok = new Button();
            prgNumeros = new ProgressBar();
            lblPorcentagem = new Label();
            numero = new Label();
            SuspendLayout();
            // 
            // rtb_numero
            // 
            rtb_numero.Enabled = false;
            rtb_numero.Location = new Point(252, 105);
            rtb_numero.Name = "rtb_numero";
            rtb_numero.Size = new Size(130, 177);
            rtb_numero.TabIndex = 0;
            rtb_numero.Text = "";
            // 
            // mtb_numeric
            // 
            mtb_numeric.Location = new Point(101, 123);
            mtb_numeric.Mask = "00000";
            mtb_numeric.Name = "mtb_numeric";
            mtb_numeric.Size = new Size(100, 23);
            mtb_numeric.TabIndex = 1;
            mtb_numeric.ValidatingType = typeof(int);
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(44, 126);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(51, 15);
            lbl_numero.TabIndex = 2;
            lbl_numero.Text = "Numero";
            // 
            // but_ok
            // 
            but_ok.Location = new Point(111, 193);
            but_ok.Name = "but_ok";
            but_ok.Size = new Size(75, 23);
            but_ok.TabIndex = 3;
            but_ok.Text = "OK";
            but_ok.UseVisualStyleBackColor = true;
            but_ok.Click += but_ok_Click;
            // 
            // prgNumeros
            // 
            prgNumeros.Location = new Point(1, 358);
            prgNumeros.Name = "prgNumeros";
            prgNumeros.Size = new Size(393, 37);
            prgNumeros.TabIndex = 4;
            prgNumeros.Click += progressBar1_Click;
            // 
            // lblPorcentagem
            // 
            lblPorcentagem.AutoSize = true;
            lblPorcentagem.Location = new Point(181, 370);
            lblPorcentagem.Name = "lblPorcentagem";
            lblPorcentagem.Size = new Size(17, 15);
            lblPorcentagem.TabIndex = 5;
            lblPorcentagem.Text = "%";
            // 
            // numero
            // 
            numero.AutoSize = true;
            numero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            numero.Location = new Point(74, 41);
            numero.Name = "numero";
            numero.Size = new Size(225, 30);
            numero.TabIndex = 6;
            numero.Text = "Insira até 10 numeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 392);
            Controls.Add(numero);
            Controls.Add(lblPorcentagem);
            Controls.Add(prgNumeros);
            Controls.Add(but_ok);
            Controls.Add(lbl_numero);
            Controls.Add(mtb_numeric);
            Controls.Add(rtb_numero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_numero;
        private MaskedTextBox mtb_numeric;
        private Label lbl_numero;
        private Button but_ok;
        private ProgressBar prgNumeros;
        private Label lblPorcentagem;
        private Label numero;
    }
}