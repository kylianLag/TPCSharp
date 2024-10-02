namespace jeux1
{
    public partial class Form1 : Form
    {
        Personnage perso { get; set; }
        Destination desti { get; set; }

        public Form1(Personnage perso , Destination desti)
        {
            InitializeComponent();
            this.perso= perso;
            this.desti = desti;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            for(int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows.Add("0", "0", "0", "0", "0");
            }

            int posXJoueur = perso.getPosX();
            int posYJoueur = perso.getPosY();

            int posXDesti = desti.getPosX();
            int posYDesti = desti.getPosY();

            dataGridView1[perso.getPosX(), perso.getPosY()].Value = "P";
            dataGridView1[desti.posX, desti.posY].Value = "D";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (perso.getPosY() <=3 )
            {
                if( perso.getPosX() == desti.getPosX() && perso.getPosY() +1 == desti.getPosY())
                {
                    MessageBox.Show("BRAVO GAGNER");
                }
                
                dataGridView1[perso.getPosX(), perso.getPosY()].Value = "0";
                perso.setPosY(perso.getPosY() + 1);
                dataGridView1[perso.getPosX(), perso.getPosY()].Value = "P";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (perso.getPosY() < 4)
            {
                if (perso.getPosX() == desti.getPosX() && perso.getPosY() -1  == desti.getPosY())
                {
                    MessageBox.Show("BRAVO GAGNER");
                   
                }
                dataGridView1[perso.getPosX(), perso.getPosY()].Value = "0";
                perso.setPosY(perso.getPosY() - 1);
                dataGridView1[perso.getPosX(), perso.getPosY()].Value = "P";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (perso.getPosX() <4)
            {
                if (perso.getPosX()+1 == desti.getPosX() && perso.getPosY()  == desti.getPosY())
                {
                    MessageBox.Show("BRAVO GAGNER");
                }
                dataGridView1[perso.getPosX(), perso.getPosY()].Value = "0";
                perso.setPosX(perso.getPosX() + 1);
                dataGridView1[perso.getPosX(), perso.getPosY()].Value = "P";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (perso.getPosX() >=1)
            {
                if (perso.getPosX()-1 == desti.getPosX() && perso.getPosY()  == desti.getPosY())
                {
                    MessageBox.Show("BRAVO GAGNER");
                }
                dataGridView1[perso.getPosX(), perso.getPosY()].Value = "0";
                perso.setPosX(perso.getPosX() - 1);
                dataGridView1[perso.getPosX(), perso.getPosY()].Value = "P";
            }
        }
    }
}