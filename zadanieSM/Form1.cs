namespace zadanieSM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pobierz mas� cia�a z textBox
            if (double.TryParse(textBox1.Text, out double masa))
            {
                // Pobierz wzrost z textBox
                if (double.TryParse(textBox2.Text, out double wzrost))
                {
                    // Oblicz BMI
                    double bmi = masa / (wzrost * wzrost);

                    // Klasyfikacja BMI
                    string klasyfikacja = "";
                    if (bmi < 18.5)
                    {
                        klasyfikacja = "Niedowaga";
                    }
                    else if (bmi >= 18.5 && bmi < 24.9)
                    {
                        klasyfikacja = "Waga prawid�owa";
                    }
                    else
                    {
                        klasyfikacja = "Nadwaga";
                    }

                    // Wy�wietl wynik w label
                    label4.Text = "Twoje BMI: " + bmi.ToString("F2") + " - " + klasyfikacja;
                }
                else
                {
                    label4.Text = "Nieprawid�owy wzrost";
                }
            }
            else
            {
                label4.Text = "Nieprawid�owa masa cia�a";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}