using Android.Content.Res;
using Android.Graphics;
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

        private void GenerateEncounterButton_Clicked(object sender, EventArgs e)
        {
            if (p_LevelPicker.SelectedItem != null && difficultyPicker.SelectedItem != null && monsterTypePicker.SelectedItem != null)
            {
                Creature encounteredCreature = encounter.Generate(Convert.ToInt32(p_LevelPicker.SelectedItem), difficultyPicker.SelectedItem.ToString(), monsterTypePicker.SelectedItem.ToString());
                creatureName.Text = "Creature Name: " + encounteredCreature.Name;
                challengeRating.Text = "Challenge Rating: " + encounteredCreature.Challenge_Rating;
                encounter.Clear();
            } else
            {
                creatureName.Text = "Please fill above inputs";
            }
            
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}