﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JobSearch.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start : ContentPage
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Detalhe(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Detalhe());
        }

        private void AddJobs(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddJob());
        }
    }
}