using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labWork1;
using View;
using labwork1_1;

namespace View
{
    public partial class AddModifyFigureForm : Form
    {

        private byte _figure;

        public IFigure Figure { get; set; }

        public AddModifyFigureForm()
        {
            InitializeComponent();
        }

        private void AddModifyFigureForm_Load(object sender, EventArgs e)
        {

        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                labWork1.IFigure figureModel = null;
                switch (_figure)
                {
                    case 0:
                        var rhombus = new Rhombus();
                        rhombus.D1 = Convert.ToInt32(TextBox1.Text);
                        rhombus.D2 = Convert.ToInt32(TextBox2.Text);
                        rhombus.X = Convert.ToInt32(TextBox7.Text);
                        rhombus.Y = Convert.ToInt32(TextBox8.Text);
                        figureModel = rhombus;
                        break;

                    case 1:
                        var rectangle = new labWork1.Rectangle();
                        rectangle.Length = Convert.ToInt32(TextBox4.Text);
                        rectangle.Width = Convert.ToInt32(TextBox5.Text);
                        rectangle.X = Convert.ToInt32(TextBox7.Text);
                        rectangle.Y = Convert.ToInt32(TextBox8.Text);
                        figureModel = rectangle;
                        break;
                    case 2:
                        var circle = new Circle();
                        circle.Radius = Convert.ToInt32(TextBox6.Text);
                        circle.X = Convert.ToInt32(TextBox7.Text);
                        circle.Y = Convert.ToInt32(TextBox8.Text);
                        figureModel = circle;
                        break;


                }
                Figure = figureModel;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);
            }
            }

   



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }




        private void TriangleRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            _figure = 0;
        }

        private void RectangleRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = false;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            _figure = 1;
        }

        private void CircleRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            _figure = 2;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

