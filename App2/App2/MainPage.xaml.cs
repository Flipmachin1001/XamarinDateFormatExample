using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Lbl_DateTime.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_Refresh_Clicked(object sender, EventArgs e)
        {
            Lbl_DateTime.Text = DateTime.Now.ToShortDateString();
        }
    }
}
