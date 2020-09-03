using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemihhovskiNewApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgisfoor2 : ContentPage
    {
        public Valgisfoor2()
        {
            //InitializeComponent();
            Label punane = new Label()
            {
                Text="Punane", 
                TextColor=Color.Black,
                FontSize=30,
                FontAttributes=FontAttributes.Bold
            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0 ,80 ,0) 
            };
            Label kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.Black,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh }
            };
            StackLayout stackLayout1 = new StackLayout()
            {
                
            };
            StackLayout stackLayout2 = new StackLayout()
            {

            };
            //stackLayout.Orientation = StackOrientation.Horizontal;
            Content = stackLayout;
            Content = stackLayout1;
            Content = stackLayout2;
        }
    }
}