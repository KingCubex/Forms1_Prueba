namespace Parte1Forms
{
    public partial class Form1 : Form
    {
        public int ConteoClicks { get; set; }
        public Form1()
        {
            InitializeComponent();
            ConteoClicks = 0;
            InicializarBoton();
        }
        private void InicializarBoton()
        {
            Button botonMostrarEtiqueta = new Button();
            botonMostrarEtiqueta.Text = "Mostrar";
            botonMostrarEtiqueta.Size = new Size(500, 250);
            botonMostrarEtiqueta.Location = new Point(50, 150);
            botonMostrarEtiqueta.Click += Mostrar_Etiqueta;
            botonMostrarEtiqueta.Click += botonGomitas_Click;
            this.Controls.Add(botonMostrarEtiqueta);
        }
        private void Mostrar_Etiqueta(object sender, EventArgs e)
        {
            Label lblEtiqueta = new Label();
            lblEtiqueta.ForeColor = Color.Aquamarine;
            lblEtiqueta.Text = "Soy una etiqueta";
            lblEtiqueta.Size = new Size(100, 50);
            lblEtiqueta.Location = new Point(200, 50);
            this.Controls.Add(lblEtiqueta);
        }
        private void botonGomitas_Click(object sender, EventArgs e)
        {
            ConteoClicks++;
            botonGomitas.Text = ConteoClicks.ToString();
        }
    }
}
