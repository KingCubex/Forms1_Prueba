namespace Parte1Forms
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
            botonGomitas = new Button();
            SuspendLayout();
            // 
            // botonGomitas
            // 
            botonGomitas.BackColor = SystemColors.ControlText;
            botonGomitas.ForeColor = SystemColors.ButtonShadow;
            botonGomitas.Location = new Point(200, 100);
            botonGomitas.Name = "botonGomitas";
            botonGomitas.Size = new Size(350, 57);
            botonGomitas.TabIndex = 0;
            botonGomitas.Text = "Boton de Gomita";
            botonGomitas.UseVisualStyleBackColor = false;
            botonGomitas.Click += botonGomitas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonGomitas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button botonGomitas;
        
    }
}
