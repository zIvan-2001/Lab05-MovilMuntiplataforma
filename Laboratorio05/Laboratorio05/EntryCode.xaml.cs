﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCode : ContentPage
    {
        public EntryCode()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();
            var entry = new Entry
            {
                Text = "This is a read-only EntryCode"
            };
            stack.Children.Add(entry);
            Content = stack;
        }
    }
}