using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Widget;
using RandomEncounter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RandomEncounter
{
    public partial class MainPage : ContentPage
    {
        List<Creature> creatures = new List<Creature>();
        Lists list = new Lists();
        Data data = new Data();
        GenerateEncounter encounter = new GenerateEncounter();
        List<Creature> encounteredCreature = new List<Creature>();
        List<Creature> emptyList = new List<Creature>();

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Checks if Database is empty

            
           
            creatures = data.CheckDB();
            
            //Sets the Picker source 
            monsterTypePicker.ItemsSource = list.CreatureType();
            p_LevelPicker.ItemsSource = list.Levels();
            difficultyPicker.ItemsSource = list.Difficulty();

        }


        /// <summary>
        /// Activates the button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateEncounterButton_Clicked(object sender, EventArgs e)
        {
            if (p_LevelPicker.SelectedItem != null && difficultyPicker.SelectedItem != null && monsterTypePicker.SelectedItem != null)
            {
                collectionView.ItemsSource = null;
                encounteredCreature = encounter.Generate(Convert.ToInt32(p_LevelPicker.SelectedItem), difficultyPicker.SelectedItem.ToString(), monsterTypePicker.SelectedItem.ToString());

                collectionView.ItemsSource = encounteredCreature;

                // Creates the Data Template for the collection view
                collectionView.ItemTemplate = new DataTemplate(() =>
                {
                    StackLayout stacklayout = new StackLayout();

                    // Creation of Labels and their styling
                    Label amount = new Label();
                    amount.Text = "Amount: 1";
                    amount.Margin = new Thickness(20, 5, 0, -5);
                    amount.FontSize = 16;
                    amount.FontAttributes = FontAttributes.Bold;
                    amount.TextColor = System.Drawing.Color.Black;
                    amount.HorizontalTextAlignment = TextAlignment.Start;

                    Label cName = new Label();
                    cName.Text = "Creature Name:";
                    cName.Margin = new Thickness(20, 0, 5, 0);
                    cName.FontSize = 16;
                    cName.FontAttributes = FontAttributes.Bold;
                    cName.TextColor = System.Drawing.Color.Black;
                    cName.HorizontalTextAlignment = TextAlignment.Start;
                    
                    Label name = new Label();
                    name.SetBinding(Label.TextProperty, "Name");
                    name.FontSize = 16;
                    name.FontAttributes = FontAttributes.Bold;
                    name.TextColor = System.Drawing.Color.Black;
                    name.Margin = new Thickness(137, -27, 0, 0);
                    name.HorizontalTextAlignment = TextAlignment.Start;

                    Label cRating = new Label();
                    cRating.Text = "Challenge Rating:";
                    cRating.Margin = new Thickness(20, 0, 0, 0);
                    cRating.FontSize = 16;
                    cRating.FontAttributes = FontAttributes.Bold;
                    cRating.TextColor = System.Drawing.Color.Black;

                    Label cr = new Label();
                    cr.SetBinding(Label.TextProperty, "Challenge_Rating");
                    cr.Margin = new Thickness(150, -27, 0, 10);
                    cr.FontSize = 16;
                    cr.FontAttributes = FontAttributes.Bold;
                    cr.TextColor = System.Drawing.Color.Black;

                    // Adding the labels to the layout
                    stacklayout.Children.Add(amount);
                    stacklayout.Children.Add(cName);
                    stacklayout.Children.Add(name);
                    stacklayout.Children.Add(cRating);
                    stacklayout.Children.Add(cr);

                    return stacklayout;
                });
                
                // Empties the list
                encounter.Clear();
            } else
            {
                // Toasts if nothing is selected
                Toast.MakeText(Android.App.Application.Context, "Pls select the above choices", ToastLength.Short).Show();
            }
            
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}