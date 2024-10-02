using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeJustePrix
{
    public partial class FormPartie : Form
    {
        public Vitrine vitrine { get; set; }
        
        



        public FormPartie(Vitrine vitrine)
        {
            InitializeComponent();
            this.vitrine = vitrine;
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPartie_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < vitrine.listArticle.Count; i++)
            {
                Article article = vitrine.listArticle[i];
                string test = article.ToString();
                listBox1.Items.Add(test);
            }
            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(textBox1.Text) == vitrine.prixTotal())
            {
                MessageBox.Show("bravo");
            }else if(Convert.ToInt32(textBox1.Text) < vitrine.prixTotal())
            {
                label2.Text = "Plus Grand !! ";

            }else if (Convert.ToInt32(textBox1.Text) > vitrine.prixTotal())
            {
                label2.Text = "Plus Petit !! ";
            }
            else
            {
                label2.Text = "ecriver des nombre  !! ";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
