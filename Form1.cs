namespace Tupakki__Kertaus_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLaske_Click(object sender, EventArgs e)
        {
            int pistemäärä = 0;
            int Kysymys2 = 0;
            Kysymys2 = int.Parse(textBox1.Text);




            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {

                if (checkBox1.Checked)
                    pistemäärä += 3;
                else if (checkBox2.Checked)
                    pistemäärä += 2;
                else if (checkBox3.Checked)
                    pistemäärä += 1;
                else if (checkBox4.Checked)
                    pistemäärä += 0;
            }
            else
            {
                MessageBox.Show("Vastaa ensimmäiseen kysymykseen!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox19.Checked || checkBox8.Checked)
            {
                if (checkBox19.Checked)
                    pistemäärä += 1;
                else if (checkBox8.Checked)
                    pistemäärä += 0;

            }
            else
            {
                MessageBox.Show("Vastaa toiseen kysymykseen!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox9.Checked || checkBox10.Checked)
            {
                if (checkBox9.Checked)
                    pistemäärä += 1;
                if (checkBox10.Checked)
                    pistemäärä += 0;
            }
            else
            {
                MessageBox.Show("Vastaa toiseen kysymykseen!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox11.Checked || checkBox12.Checked)
            {
                if (checkBox11.Checked)
                    pistemäärä += 1;
                if (checkBox12.Checked)
                    pistemäärä += 0;
            }
            else
            {
                MessageBox.Show("Vastaa toiseen kysymykseen!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox13.Checked || checkBox14.Checked)
            {
                if (checkBox13.Checked)
                    pistemäärä += 1;
                if (checkBox14.Checked)
                    pistemäärä += 0;
            }
            else
            {
                MessageBox.Show("Vastaa toiseen kysymykseen!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Kysymys2 >= 10)
            {
                label10.Show();
                checkBox5.Show();
                checkBox7.Show();
                checkBox6.Show();
                textBox2.Show();
                label9.Show();
                label11.Show();
                label12.Show();
                btnLaske2.Show();
            }
            if (checkBox5.Checked || checkBox6.Checked || checkBox7.Checked)
            {
                if (checkBox5.Checked)
                    pistemäärä += 1;
                if (checkBox6.Checked)
                    pistemäärä += 2;
                if (checkBox7.Checked)
                    pistemäärä += 3;

            }


            lblTulos.Text = $"Nikotiiniriippuvuuden pistemäärä: {pistemäärä}";


            if (pistemäärä >= 5)
                lblTulos.Text += "\nKorkea riippuvuus";
            else if (pistemäärä >= 3)
                lblTulos.Text += "\nKohtalainen riippuvuus";
            else
                lblTulos.Text += "\nEi merkittävää riippuvuutta";




        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLaske2_Click(object sender, EventArgs e)
        {
            int kysymys3 = 0;
            double vastaus1 = 0;
            double vastaus2 = 0;
            kysymys3 = int.Parse(textBox2.Text);

            vastaus1 = kysymys3 * 30;
            vastaus2 = kysymys3 * 365;

            label11.Text = $"Kuukaudessa: {vastaus1}";
            label12.Text = $"Vuodessa: {vastaus2}";




        }
    }
}