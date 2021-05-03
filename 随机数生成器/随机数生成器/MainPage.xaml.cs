using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace 随机数生成器
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Random rd = new Random();
            if (int.Parse(text1.Text) < int.Parse(text2.Text))
            label1.Text = rd.Next(int.Parse(text1.Text), int.Parse(text2.Text)+1).ToString() ;

        }
    }
}
