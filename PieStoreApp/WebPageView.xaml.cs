﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PieStoreApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebPageView : ContentPage
	{
		public WebPageView ()
		{
			InitializeComponent ();
		}
	}
}