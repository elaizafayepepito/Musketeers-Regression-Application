using Accord.Statistics.Models.Regression.Linear;

namespace Musketeers_RegressionApplication
{
    public partial class Form1 : Form
    {
        double[][] inputs =
        {
            new double[] { 45, 155, 57 },
            new double[] { 60, 180, 73 },
            new double[] { 36, 158, 59 },
            new double[] { 52, 183, 93 },
            new double[] { 38, 166, 88 },
            new double[] { 30, 160, 69 },
            new double[] { 33, 150, 54 },
            new double[] { 23, 181, 79 },
            new double[] { 48, 169, 74 },
            new double[] { 38, 182, 93 },
            new double[] { 60, 175, 74 },
            new double[] { 66, 186, 67 },
            new double[] { 24, 178, 57 },
            new double[] { 46, 184, 97 },
            new double[] { 18, 150, 76 },
            new double[] { 38, 160, 68 },
            new double[] { 42, 149, 67 },
            new double[] { 38, 154, 82 },
            new double[] { 57, 156, 61 },
            new double[] { 21, 186, 97 }
        };

        double[] outputs = { 25000, 29000, 23000, 28000, 23000,
                             23000, 21000, 15000, 23000, 23000,
                             28000, 25000, 15000, 35000, 15000,
                             23000, 30000, 23000, 25000, 15000};

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var regression = new MultipleLinearRegression();
            var regress = regression.Regress(inputs, outputs);

            // use the model to make predictions
            var age = textBox1.Text;
            var height = textBox2.Text;
            var weight = textBox3.Text;

            double[] input = { Convert.ToDouble(age), Convert.ToDouble(height), Convert.ToDouble(weight) };
            double prediction = regression.Transform(input);
            textBox4.Text = "Php " + prediction.ToString("F");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}