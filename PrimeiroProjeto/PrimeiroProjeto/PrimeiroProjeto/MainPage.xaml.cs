﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeiroProjeto
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

        private void btnClick_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = string.Format("Você digitou: {0}", txtValue.Text);
        }
    }
}
