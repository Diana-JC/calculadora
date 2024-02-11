namespace calculadora
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
            txt_Resta = new TextBox();
            txt_Division = new TextBox();
            txt_Valor1 = new TextBox();
            txt_Suma = new TextBox();
            txt_Valor2 = new TextBox();
            btn_Calcular = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            txt_Multiplicacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txt_Resta
            // 
            txt_Resta.Font = new Font("Segoe UI", 10F);
            txt_Resta.Location = new Point(189, 220);
            txt_Resta.Name = "txt_Resta";
            txt_Resta.Size = new Size(99, 34);
            txt_Resta.TabIndex = 0;
            txt_Resta.TextChanged += textBox1_TextChanged;
            // 
            // txt_Division
            // 
            txt_Division.Font = new Font("Segoe UI", 10F);
            txt_Division.Location = new Point(189, 370);
            txt_Division.Name = "txt_Division";
            txt_Division.Size = new Size(99, 34);
            txt_Division.TabIndex = 1;
            // 
            // txt_Valor1
            // 
            txt_Valor1.Font = new Font("Segoe UI", 10F);
            txt_Valor1.Location = new Point(478, 143);
            txt_Valor1.Name = "txt_Valor1";
            txt_Valor1.Size = new Size(95, 34);
            txt_Valor1.TabIndex = 2;
            txt_Valor1.TextChanged += textBox3_TextChanged;
            // 
            // txt_Suma
            // 
            txt_Suma.Font = new Font("Segoe UI", 10F);
            txt_Suma.Location = new Point(189, 145);
            txt_Suma.Name = "txt_Suma";
            txt_Suma.Size = new Size(99, 34);
            txt_Suma.TabIndex = 3;
            // 
            // txt_Valor2
            // 
            txt_Valor2.Font = new Font("Segoe UI", 10F);
            txt_Valor2.Location = new Point(478, 220);
            txt_Valor2.Name = "txt_Valor2";
            txt_Valor2.Size = new Size(95, 34);
            txt_Valor2.TabIndex = 4;
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor = Color.White;
            btn_Calcular.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_Calcular.Location = new Point(314, 342);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(112, 40);
            btn_Calcular.TabIndex = 5;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.White;
            btn_Limpiar.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(425, 420);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(112, 40);
            btn_Limpiar.TabIndex = 6;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.White;
            btn_Salir.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_Salir.Location = new Point(561, 342);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(112, 40);
            btn_Salir.TabIndex = 7;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Multiplicacion
            // 
            txt_Multiplicacion.Font = new Font("Segoe UI", 10F);
            txt_Multiplicacion.Location = new Point(189, 293);
            txt_Multiplicacion.Name = "txt_Multiplicacion";
            txt_Multiplicacion.Size = new Size(99, 34);
            txt_Multiplicacion.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label1.Location = new Point(390, 145);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 10;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label2.Location = new Point(390, 220);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 11;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label3.Location = new Point(108, 147);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 12;
            label3.Text = "Suma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label4.Location = new Point(111, 220);
            label4.Name = "label4";
            label4.Size = new Size(68, 32);
            label4.TabIndex = 13;
            label4.Text = "Resta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label5.Location = new Point(29, 293);
            label5.Name = "label5";
            label5.Size = new Size(155, 32);
            label5.TabIndex = 14;
            label5.Text = "Multiplicacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label6.Location = new Point(87, 370);
            label6.Name = "label6";
            label6.Size = new Size(96, 32);
            label6.TabIndex = 15;
            label6.Text = "Division";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Subheading", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(204, 9);
            label7.Name = "label7";
            label7.Size = new Size(266, 63);
            label7.TabIndex = 16;
            label7.Text = "Calculadora";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(685, 495);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Multiplicacion);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcular);
            Controls.Add(txt_Valor2);
            Controls.Add(txt_Suma);
            Controls.Add(txt_Valor1);
            Controls.Add(txt_Division);
            Controls.Add(txt_Resta);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Resta;
        private TextBox txt_Division;
        private TextBox txt_Valor1;
        private TextBox txt_Suma;
        private TextBox txt_Valor2;
        private Button btn_Calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txt_Multiplicacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
