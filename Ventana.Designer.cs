namespace AppPracticaTCOM
{
    partial class Ventana
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
            labelTitulo = new Label();
            buttonBuscar = new Button();
            richTextBoxBytes = new RichTextBox();
            textBoxRuta = new TextBox();
            buttonAnalisis = new Button();
            buttonLimpiar = new Button();
            textBoxVirusEncontrado = new TextBox();
            textboxNombreArchivo = new TextBox();
            labelNombreArchivo = new Label();
            labelBytes = new Label();
            labelVirusDetectado = new Label();
            label2 = new Label();
            textBoxEstadoFinal = new TextBox();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Cooper Black", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.Location = new Point(17, 27);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(158, 20);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Analizador Virus";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(402, 57);
            buttonBuscar.Margin = new Padding(2, 3, 2, 3);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(100, 31);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // richTextBoxBytes
            // 
            richTextBoxBytes.Location = new Point(11, 194);
            richTextBoxBytes.Margin = new Padding(2, 3, 2, 3);
            richTextBoxBytes.Name = "richTextBoxBytes";
            richTextBoxBytes.ReadOnly = true;
            richTextBoxBytes.Size = new Size(491, 128);
            richTextBoxBytes.TabIndex = 2;
            richTextBoxBytes.Text = "";
            richTextBoxBytes.TextChanged += richTextBoxBytes_TextChanged;
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(11, 59);
            textBoxRuta.Margin = new Padding(3, 4, 3, 4);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(375, 27);
            textBoxRuta.TabIndex = 3;
            textBoxRuta.TextChanged += textBoxRuta_TextChanged;
            // 
            // buttonAnalisis
            // 
            buttonAnalisis.Enabled = false;
            buttonAnalisis.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAnalisis.Location = new Point(403, 369);
            buttonAnalisis.Margin = new Padding(3, 4, 3, 4);
            buttonAnalisis.Name = "buttonAnalisis";
            buttonAnalisis.Size = new Size(99, 31);
            buttonAnalisis.TabIndex = 4;
            buttonAnalisis.Text = "Analizar";
            buttonAnalisis.UseVisualStyleBackColor = true;
            buttonAnalisis.Click += buttonAnalisis_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(403, 452);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(99, 29);
            buttonLimpiar.TabIndex = 5;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxVirusEncontrado
            // 
            textBoxVirusEncontrado.Location = new Point(11, 371);
            textBoxVirusEncontrado.Name = "textBoxVirusEncontrado";
            textBoxVirusEncontrado.Size = new Size(375, 27);
            textBoxVirusEncontrado.TabIndex = 6;
            textBoxVirusEncontrado.TextChanged += textBoxVirusEncontrado_TextChanged;
            // 
            // textboxNombreArchivo
            // 
            textboxNombreArchivo.Location = new Point(184, 102);
            textboxNombreArchivo.Name = "textboxNombreArchivo";
            textboxNombreArchivo.Size = new Size(318, 27);
            textboxNombreArchivo.TabIndex = 7;
            textboxNombreArchivo.TextChanged += textboxNombreArchivo_TextChanged;
            // 
            // labelNombreArchivo
            // 
            labelNombreArchivo.AutoSize = true;
            labelNombreArchivo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNombreArchivo.Location = new Point(11, 102);
            labelNombreArchivo.Name = "labelNombreArchivo";
            labelNombreArchivo.Size = new Size(150, 20);
            labelNombreArchivo.TabIndex = 8;
            labelNombreArchivo.Text = "Nombre del Archivo:";
            labelNombreArchivo.Click += labelNombreArchivo_Click;
            // 
            // labelBytes
            // 
            labelBytes.AutoSize = true;
            labelBytes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelBytes.Location = new Point(11, 151);
            labelBytes.Name = "labelBytes";
            labelBytes.Size = new Size(144, 20);
            labelBytes.TabIndex = 10;
            labelBytes.Text = "Contenido en Bytes:";
            // 
            // labelVirusDetectado
            // 
            labelVirusDetectado.AutoSize = true;
            labelVirusDetectado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelVirusDetectado.Location = new Point(11, 338);
            labelVirusDetectado.Name = "labelVirusDetectado";
            labelVirusDetectado.Size = new Size(122, 20);
            labelVirusDetectado.TabIndex = 11;
            labelVirusDetectado.Text = "Virus Detectado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(11, 417);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 12;
            label2.Text = "Estado Final Programa:";
            // 
            // textBoxEstadoFinal
            // 
            textBoxEstadoFinal.Location = new Point(11, 452);
            textBoxEstadoFinal.Name = "textBoxEstadoFinal";
            textBoxEstadoFinal.Size = new Size(375, 27);
            textBoxEstadoFinal.TabIndex = 13;
            textBoxEstadoFinal.TextChanged += textBoxEstadoFinal_TextChanged;
            // 
            // Ventana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 537);
            Controls.Add(textBoxEstadoFinal);
            Controls.Add(label2);
            Controls.Add(labelVirusDetectado);
            Controls.Add(labelBytes);
            Controls.Add(labelNombreArchivo);
            Controls.Add(textboxNombreArchivo);
            Controls.Add(textBoxVirusEncontrado);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonAnalisis);
            Controls.Add(textBoxRuta);
            Controls.Add(richTextBoxBytes);
            Controls.Add(buttonBuscar);
            Controls.Add(labelTitulo);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Ventana";
            Text = "Analizador de Virus";
            Load += Ventana_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private Button buttonBuscar;
        private RichTextBox richTextBoxBytes;
        private TextBox textBoxRuta;
        private Button buttonAnalisis;
        private Button buttonLimpiar;
        private TextBox textBoxVirusEncontrado;
        private TextBox textboxNombreArchivo;
        private Label labelNombreArchivo;
        private Label labelBytes;
        private Label labelVirusDetectado;
        private Label label2;
        private TextBox textBoxEstadoFinal;
    }
}