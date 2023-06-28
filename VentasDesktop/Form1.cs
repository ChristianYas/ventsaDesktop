using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasDesktop.Forms;
using VentasDesktop.Models;

namespace VentasDesktop
{
    public partial class Form1 : Form
    {
        public static List<string> colorsList = new List<string> { "#3F51B5",
                                                                   "#009688",
                                                                   "#FF5722",
                                                                   "#FF9800" };

        private Button currentButton;
        private Color color;
        private int opacity = 100;
        private Color tranparentColor;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle= FormBorderStyle.FixedDialog;
            this.Size = new Size(1200, 600);
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            OpenChildForm(new Forms.HomePage());
        }

        public void resetButtonsColor()
        {

            foreach(Control control in panelMenu.Controls)
            {
                if(control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(51, 51, 76);
                }
            }
        }

        public void addColorButton(object sender)
        {

            currentButton = sender as Button;
            
            switch(currentButton.Name)
            {
                case "btnSalesByProduct":

                    color = ColorTranslator.FromHtml(colorsList[0]);

                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar.BackColor = color;

                    tranparentColor = Color.FromArgb(opacity, color);

                    panelLogo.BackColor = tranparentColor;

                    break;

                case "btnAllSales":
                    color = ColorTranslator.FromHtml(colorsList[1]);

                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar.BackColor = color;

                    tranparentColor = Color.FromArgb(opacity, color);

                    panelLogo.BackColor = tranparentColor;

                    break;


                case "btnBestSelling":
                    color = ColorTranslator.FromHtml(colorsList[2]);

                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar.BackColor = color;

                    tranparentColor = Color.FromArgb(opacity, color);

                    panelLogo.BackColor = tranparentColor;

                    break;

                case "btnAmountSales":
                    color = ColorTranslator.FromHtml(colorsList[3]);

                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar.BackColor = color;

                    tranparentColor = Color.FromArgb(opacity, color);

                    panelLogo.BackColor = tranparentColor;

                    break;
            }

        }

        private void OpenChildForm(Form childForm)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDekstopPane.Controls.Add(childForm);
            panelDekstopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;


        }

        private void salesByProduct_Click(object sender, EventArgs e)
        {

            resetButtonsColor();
            addColorButton(sender);
            OpenChildForm(new Forms.FormSalesByProduct());
                
        }

        private void allSales_Click(object sender, EventArgs e)
        {

            resetButtonsColor();
            addColorButton(sender);
            OpenChildForm(new Forms.AllSales());

        }

        private void bestSelling_Click(object sender, EventArgs e)
        {
            resetButtonsColor();
            addColorButton(sender);
            OpenChildForm(new Forms.BestSelling());
            
        }

        private void amountSales_Click(object sender, EventArgs e)
        {
            resetButtonsColor();
            addColorButton(sender);
            OpenChildForm(new Forms.ExistingProducts());
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
