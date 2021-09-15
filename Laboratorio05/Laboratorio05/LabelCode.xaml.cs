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
    public partial class LabelCode : ContentPage
    {
        public LabelCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var underlineLabel = new Label
            {
                Text = "This is underlined text.",
                TextDecorations = TextDecorations.Underline
            };

            var strikethroghLabel = new Label
            {
                Text = "This is text with strikethrough",
                TextDecorations = TextDecorations.Strikethrough
            };

            var bothLabel = new Label
            {
                Text = "This is underlined text with strikethrough.",
                TextDecorations = TextDecorations.Underline | TextDecorations.Strikethrough
            };

            stack.Children.Add(underlineLabel);
            stack.Children.Add(strikethroghLabel);
            stack.Children.Add(strikethroghLabel);
            Content = stack;
        }
    }
}