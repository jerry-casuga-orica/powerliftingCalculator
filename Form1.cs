namespace StrengthCalculator
{
    public partial class Form1 : Form
    {
        private double weightLifted;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void squatTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void benchTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void deadliftTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (int.TryParse(squatTotal.Text, out int num2) && int.TryParse(benchTotal.Text, out int num3) && int.TryParse(deadliftTotal.Text, out int num4))
            {
                sum = num2 + num3 + num4;
                result.Text = $"{sum}kg total";
            }
            double bodyweight = double.Parse(weightTotal.Text);

            bool isFemale = femaleButton.Checked;

            double[] maleCoeff = { -307.75076, 24.0900756, -0.1918759221, 0.0007391293, -0.000001093 };
            double[] femaleCoeff = { -57.96288, 13.6175032, -0.1126655495, 0.0005158568, -0.0000010706 };

            double denominator = isFemale ? femaleCoeff[0] : maleCoeff[0];
            double[] coeff = isFemale ? femaleCoeff : maleCoeff;
            double maxbw = isFemale ? 150 : 210;
            double bw = Math.Min(Math.Max(bodyweight, 40), maxbw);

            for (int i = 1; i < coeff.Length; i++)
            {
                denominator += coeff[i] * Math.Pow(bw, i);
            }
            double score = (500 / denominator) * sum;

            dotsLabel.Text = score.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton == maleButton && maleButton.Checked)
            {
                femaleButton.Checked = false;
            }
            else if (radioButton == femaleButton && femaleButton.Checked)
            {
                maleButton.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}