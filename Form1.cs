using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace Lab_03_BV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtH.Text = Properties.Settings.Default.H.ToString();
            txtS.Text = Properties.Settings.Default.S.ToString();
            txtV.Text = Properties.Settings.Default.V.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void AutoColor()
        {
            try
            {
                var h = int.Parse(txtH.Text);
                var s = int.Parse(txtS.Text);
                var v = int.Parse(txtV.Text);
                HSV hsv = new HSV(h, s, v);
                RGB rgb1 = hsv.HSVToRGB();
                hsv.CheckHSV();
                colorShowerStart.BackColor = System.Drawing.Color.FromArgb(rgb1.R, rgb1.G, rgb1.B);
            }
            catch (FormatException)
            {
                return;
            }
            catch (Exception)
            {
                return;
            }
        }
        private void Calculate(int i)
        {
            try { 
            var h = int.Parse(txtH.Text);
            var s = int.Parse(txtS.Text);
            var v = int.Parse(txtV.Text);
                HSV hsv = new HSV(h, s, v);
                RGB rgb1 = hsv.HSVToRGB();
                hsv.CheckHSV();
                colorShowerStart.BackColor = System.Drawing.Color.FromArgb(rgb1.R, rgb1.G, rgb1.B);
                if (i == 1)
                {
                    switch (cmbOperation.Text)
                    {
                        case "+":
                            switch (cmbTypes.Text)
                            {
                                case "R":
                                    hsv = hsv + new Red(int.Parse(txtTerm.Text));
                                    break;
                                case "G":
                                    hsv = hsv + new Green(int.Parse(txtTerm.Text));
                                    break;
                                case "B":
                                    hsv = hsv + new Blue(int.Parse(txtTerm.Text));
                                    break;
                                case "S":
                                    hsv = hsv + new Saturation(int.Parse(txtTerm.Text));
                                    break;
                                case "V":
                                    hsv = hsv + new Value(int.Parse(txtTerm.Text));
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "-":
                            switch (cmbTypes.Text)
                            {
                                case "R":
                                    hsv = hsv - new Red(int.Parse(txtTerm.Text));
                                    break;
                                case "G":
                                    hsv = hsv - new Green(int.Parse(txtTerm.Text));
                                    break;
                                case "B":
                                    hsv = hsv - new Blue(int.Parse(txtTerm.Text));
                                    break;
                                case "S":
                                    hsv = hsv - new Saturation(int.Parse(txtTerm.Text));
                                    break;
                                case "V":
                                    hsv = hsv - new Value(int.Parse(txtTerm.Text));
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    
                    hsv.CheckHSV();
                    RGB rgb = hsv.HSVToRGB();
                    rgb.CheckRGB();
                    labelHR.Text = "H [0..360]";
                    labelSG.Text = "S [0..100]";
                    labelVB.Text = "V [0..100]";
                    txtResH.Text = hsv.H.ToString();
                    txtResS.Text = hsv.S.ToString();
                    txtResV.Text = hsv.V.ToString();
                    colorShowerRes.BackColor = System.Drawing.Color.FromArgb(rgb.R, rgb.G, rgb.B);
                }
                else if (i == 2)
                {
                    colorShowerStart.BackColor = System.Drawing.Color.FromArgb(rgb1.R, rgb1.G, rgb1.B);
                    hsv.CheckHSV();
                    RGB rgb = hsv.HSVToRGB();
                    rgb.CheckRGB();
                    labelHR.Text = "R [0..255]";
                    labelSG.Text = "G [0..255]";
                    labelVB.Text = "B [0..255]";
                    txtResH.Text = rgb.R.ToString();
                    txtResS.Text = rgb.G.ToString();
                    txtResV.Text = rgb.B.ToString();
                    colorShowerRes.BackColor = System.Drawing.Color.FromArgb(rgb.R,rgb.G,rgb.B);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(Exception e)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {
            AutoColor();
        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {
            AutoColor();
        }

        private void txtV_TextChanged(object sender, EventArgs e)
        {
            AutoColor();
        }

        private void txtTerm_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bnSolve_Click(object sender, EventArgs e)
        {
            Calculate(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(2);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}