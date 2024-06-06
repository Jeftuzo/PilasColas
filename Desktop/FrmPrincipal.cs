namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArreglosPilas_Click(object sender, EventArgs e)
        {
            FrmArreglosPilas frmArreglosPilas = new FrmArreglosPilas();
            frmArreglosPilas.ShowDialog();
        }

        private void btnArreglosColas_Click(object sender, EventArgs e)
        {
            FrmArreglosColas frmArreglosColas = new FrmArreglosColas();
            frmArreglosColas.ShowDialog();
        }
    }
}