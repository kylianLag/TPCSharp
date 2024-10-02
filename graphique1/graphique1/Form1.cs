namespace graphique1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string val1 = saisie1.Text;
            string val2 = saisie2.Text;
            int sais1 = Convert.ToInt32(val1);
            int sais2 = Convert.ToInt32(val2);
            int resultat = sais1 - sais2;
            res.Text = resultat.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //recup les valeurs dans les champs de saisie et on s'assure qu'elles sont bien des chiffre on convertie en int et on additionne et on met a jour le texte de res avec le res trouvé

            string val1 = saisie1.Text;
            string val2= saisie2.Text;
            int sais1 = Convert.ToInt32(val1);
            int sais2 = Convert.ToInt32(val2);
            int resultat= sais1 + sais2;
            res.Text = resultat.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            string val1 = saisie1.Text;
            string val2 = saisie2.Text;
            int sais1 = Convert.ToInt32(val1);
            int sais2 = Convert.ToInt32(val2);
            int resultat = sais1 * sais2;
            res.Text = resultat.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string val1 = saisie1.Text;
            string val2 = saisie2.Text;
            double sais1 = Convert.ToDouble(val1);
            double sais2 = Convert.ToDouble(val2);
            double resultat = sais1 / sais2;
            res.Text = resultat.ToString();
        }
    }
}