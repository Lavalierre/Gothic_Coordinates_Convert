using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2O_CoordinatesConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private double anx(int x)
        {
            if (screenResX_box.Text.Length != 0)
            {
                int screenX = int.Parse(screenResX_box.Text);
                float virtualX = (x * 8192) / screenX;
                return Math.Ceiling(virtualX);
            }
            else
                return 0.0;
        }

        private double any(int x)
        {
            if (screenResY_box.Text.Length != 0)
            {
                int screenX = int.Parse(screenResY_box.Text);
                float virtualX = (x * 8192) / screenX;
                return Math.Ceiling(virtualX);
            }
            else
                return 0.0;
        }

        public void updateAnx()
        {
            if (inputX_box.Text.Length != 0)
            {
                int pX = int.Parse(inputX_box.Text);
                outputX_label.Text = "X: " + anx(pX);
            }

            if (inputW_box.Text.Length != 0)
            {
                int pX = int.Parse(inputW_box.Text);
                outputW_label.Text = "W: " + anx(pX);
            }
        }

        public void updateAny()
        {
            if (inputY_box.Text.Length != 0)
            {
                int pY = int.Parse(inputY_box.Text);
                outputY_label.Text = "Y: " + any(pY);
            }

            if (inputH_box.Text.Length != 0)
            {
                int pY = int.Parse(inputH_box.Text);
                outputH_label.Text = "H: " + any(pY);
            }
        }


        // Ввод данных - X координата
        private void inputX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void inputX_TextChanged(object sender, EventArgs e)
        {
            updateAnx();
        }

        // Ввод данных - Y координата
        private void inputY_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void inputY_TextChanged(object sender, EventArgs e)
        {
            updateAny();
        }

        // Ввод данных - W (ширина)
        private void inputW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void inputW_TextChanged(object sender, EventArgs e)
        {
            updateAnx();
        }

        // Ввод данных - H (высота)
        private void inputH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void inputH_TextChanged(object sender, EventArgs e)
        {
            updateAny();
        }

        // Ввод данных - разрешение экрана X
        private void screenResX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void screenResX_TextChanged(object sender, EventArgs e)
        {
            updateAnx();
        }

        // Ввод данных - разрешение экрана Y
        private void screenResY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void screenResY_TextChanged(object sender, EventArgs e)
        {
            updateAny();
        }
    }
}
