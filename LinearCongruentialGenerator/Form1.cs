using System;
using System.Windows.Forms;

namespace LinearCongruentialGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            const int min = 50;
            const int max = 100;
            var rndn = new Random();
            N.Text = rndn.Next(min, max).ToString();

            if (N.Text != "" && NMAX.Text != "" && A.Text != "" && C.Text != "" && M.Text != "")
            {
                // Получение входных параметров
                var n = Convert.ToInt64(N.Text);       // Количество генерируемых чисел
                var nmax = Convert.ToInt64(NMAX.Text); // Диапазон
                var a = Convert.ToInt64(A.Text);       // Множитель
                var c = Convert.ToInt64(C.Text);       // Приращение
                var m = Convert.ToInt64(M.Text);       // Модуль
                if (n > 0 && nmax > 0 && a >= 0 && a < m && c >= 0 && c < m && m > 0)
                {
                    // Экземпляр ЛКГ
                    var rng = new RandomNumberGenerator(a, c, m);

                    // Диапазон значений по оси Y от 0 до 1
                    Histogram.ChartAreas[0].AxisX.Minimum = 0;
                    Histogram.ChartAreas[0].AxisX.Maximum = nmax;

                    var ni = rng.Next(nmax);
                    Histogram.Series["RND"].Points.AddXY(ni, n);
                }
                else
                {
                    const string caption = "Ошибка!";
                    const MessageBoxButtons buttons = MessageBoxButtons.OK;
                    const string message = "Параметры введены не правильно.";
                    MessageBox.Show(message, caption, buttons);
                }


            }
            else
            {
                const string caption = "Ошибка!";
                const MessageBoxButtons buttons = MessageBoxButtons.OK;
                const string message = "Один из параметров не заполнен.";
                MessageBox.Show(message, caption, buttons);
            }


        }

        private void N_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NMAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void M_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Histogram.Series["RND"].Points.Clear();
        }
    }
}
