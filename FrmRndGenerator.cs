namespace WFA24100902
{
    public partial class FrmRndGenerator : Form
    {
        private static Random rnd = new();

        public FrmRndGenerator()
        {
            InitializeComponent();
            btnGeneralas.Click += BtnGeneralas_Click;
        }

        private void BtnGeneralas_Click(object? sender, EventArgs e)
        {
            rtbSzamok.Clear();
            for (int i = 0; i < 100; i++) rtbSzamok.Text += 
                    $"{rnd.Next((int)nudMin.Value, (int)nudMax.Value + 1)} ";
        }
    }
}
