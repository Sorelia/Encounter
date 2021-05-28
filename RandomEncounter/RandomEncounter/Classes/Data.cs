using Android.Content.Res;
using RandomEncounter.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RandomEncounter.Classes
{
    class Data : IData
    {
        List<Creature> creatures = new List<Creature>();
        /// <summary>
        /// Checks if db is created
        /// </summary>
        /// <returns></returns>
        public List<Creature> CheckDB()
        {
            
                if (App.Database.GetCreaturesAsync().Result.Count != 0)
                {
                    creatures.Add(new Creature { Name = "No Creatures found" });
                    return creatures;
                }
                else // if not Add data to database
                {
                    FillDB(creatures);
                } 
            

            return creatures;
        }
        /// <summary>
        /// Adds data to db if it's created
        /// </summary>
        /// <returns></returns>
        public string FillDB(List<Creature> creatures)
        {
            List<string> text = new List<string>();
            AssetManager assets = Android.App.Application.Context.Assets;
            using (StreamReader sr = new StreamReader(assets.Open("Creatures.csv")))
            {
                while (!sr.EndOfStream)
                {
                    text.Add(sr.ReadLine());
                    //Console.WriteLine("test: "+text);
                }
                creatures = text.Skip(1).Select(v => FromCSV(v)).ToList();
            }


            foreach (var item in creatures)
            {
                App.Database.SaveCreatureAsync(new Creature
                {
                    Name = item.Name,
                    Type = item.Type,
                    Challenge_Rating = item.Challenge_Rating
                });
            }
            string val = "Database has been filled";
            return val;
        }
        /// <summary>
        /// Reads a list and returns a creature
        /// </summary>
        /// <param name="csvLine"></param>
        /// <returns></returns>
        public Creature FromCSV(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Creature creature = new Creature();
            creature.Name = values[0];
            Console.WriteLine(creature.Name);
            creature.Type = values[1];
            if (values.Length > 3)
            {
                string value = values[2] + "." + values[3];
                creature.Challenge_Rating = float.Parse(value);
            }
            else
            {
                creature.Challenge_Rating = float.Parse(values[2]);
            }


            return creature;
        }
    }
}
