namespace mathematics1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Result CalculateAll(double L, double a, double b, double l, double r)
        {
            Result calculationResult = new Result();
            calculationResult.BrickVolume = L * a * b;
            calculationResult.CylinderVolume = r * r * l * Math.PI;

            return calculationResult;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double L = double.Parse(LTXT.Text);
            double a = double.Parse(aTXT.Text);
            double b = double.Parse(bTXT.Text);
            double l = double.Parse(smalllTXT.Text);
            double r = double.Parse(rTXT.Text);

            Result calculationResult = CalculateAll(L, a, b, l, r);

            BrickVolume.Text = calculationResult.BrickVolume.ToString();
            CylinderVolume.Text = calculationResult.CylinderVolume.ToString();
            Rubbish.Text = (calculationResult.Rubbish * 100).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Result
    {
        public double BrickVolume;
        public double CylinderVolume;
        public double Rubbish => (this.BrickVolume - this.CylinderVolume) / this.BrickVolume;
    }
}
