﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Due_It
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdjustCourses : ContentPage
    {
        public AdjustCourses()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddCourse());
        }
    }
}