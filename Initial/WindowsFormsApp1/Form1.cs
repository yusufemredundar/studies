using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Formun kod tarafı, tasarım tarafı olmak üzere 2 temel yapısı var
            //Form üstündeki nesnelerin özellikleri(property), olayları(event) olmak üzere 2 temel yapısı var
            //Sayı kutusuna girilen değeri almak için Value özelliği(propertysi) alınır
            //Butona tıklama bir olaydır
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sayi1 = (int)nmSayi1.Value;
            int sayi2 = (int)nmSayi2.Value;
            MessageBox.Show("Sonuç=" + (sayi1 + sayi2));
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.SeaGreen;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.CornflowerBlue;
        }
        //toplama metodu çıkar metodu
    }
}
