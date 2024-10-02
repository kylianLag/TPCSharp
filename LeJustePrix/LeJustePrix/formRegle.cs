namespace LeJustePrix
{
    public partial class formRegle : Form
    {
        public Vitrine vitrine { get; set; }
        public formRegle(Vitrine vitrine)
        {
            InitializeComponent();
            this.vitrine = vitrine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormPartie form = new FormPartie(vitrine);
            form.Show();
            this.Hide();
            
        }

        private void formRegle_Load(object sender, EventArgs e)
        {

        }
    }
}