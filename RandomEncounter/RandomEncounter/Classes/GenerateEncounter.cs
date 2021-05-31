using RandomEncounter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomEncounter.Classes
{
    class GenerateEncounter : IGenerateEncounter
    {
        Random rnd;
        List<Creature> creatures = new List<Creature>();

        /// <summary>
        /// Emptys the list, so it's ready for the next encounter
        /// </summary>
        public void Clear()
        {
            creatures.RemoveRange(0, creatures.Count);
        }

        /// <summary>
        /// Generates a challenge rating based on inputs
        /// </summary>
        /// <param name="level"></param>
        /// <param name="difficulty"></param>
        /// <returns></returns>
        public float GenerateChallengeRating(int level, string difficulty)
        {
             float cr = 1f;
            if (difficulty == "Easy")
            {
                switch (level)
                {
                    case 1:
                        cr = 0;
                        break;
                    case 2:
                        cr = 0.125f;
                        break;
                    case 3:
                        cr = 0.25f;
                        break;
                    case 4:
                        cr = 0.5f;
                        break;
                    case 5:
                        cr = level - 4;
                        break;
                    case 6:
                        cr = level - 4;
                        break;
                    case 7:
                        cr = level - 4;
                        break;
                    case 8:
                        cr = level - 4;
                        break;
                    case 9:
                        cr = level - 4;
                        break;
                    case 10:
                        cr = level - 4;
                        break;
                    case 11:
                        cr = level - 4;
                        break;
                    case 12:
                        cr = level - 4;
                        break;
                    case 13:
                        cr = level - 4;
                        break;
                    case 14:
                        cr = level - 4;
                        break;
                    case 15:
                        cr = level - 4;
                        break;
                    case 16:
                        cr = level - 4;
                        break;
                    case 17:
                        cr = level - 4;
                        break;
                    case 18:
                        cr = level - 4;
                        break;
                    case 19:
                        cr = level - 4;
                        break;
                    case 20:
                        cr = level - 4;
                        break;

                }
            }
            else if (difficulty == "Medium")
            {
                switch (level)
                {
                    case 1:
                        cr = 0.125f;
                        break;
                    case 2:
                        cr = 0.25f;
                        break;
                    case 3:
                        cr = 0.5f;
                        break;
                    case 4:
                        cr = 1;
                        break;
                    case 5:
                        cr = level - 3;
                        break;
                    case 6:
                        cr = level - 3;
                        break;
                    case 7:
                        cr = level - 3;
                        break;
                    case 8:
                        cr = level - 3;
                        break;
                    case 9:
                        cr = level - 3;
                        break;
                    case 10:
                        cr = level - 3;
                        break;
                    case 11:
                        cr = level - 3;
                        break;
                    case 12:
                        cr = level - 3;
                        break;
                    case 13:
                        cr = level - 3;
                        break;
                    case 14:
                        cr = level - 3;
                        break;
                    case 15:
                        cr = level - 3;
                        break;
                    case 16:
                        cr = level - 3;
                        break;
                    case 17:
                        cr = level - 3;
                        break;
                    case 18:
                        cr = level - 3;
                        break;
                    case 19:
                        cr = level - 3;
                        break;
                    case 20:
                        cr = level - 3;
                        break;

                }
            }
            else if (difficulty == "Hard")
            {
                switch (level)
                {
                    case 1:
                        cr = 0.25f;
                        break;
                    case 2:
                        cr = 0.5f;
                        break;
                    case 3:
                        cr = 1f;
                        break;
                    case 4:
                        cr = level - 2;
                        break;
                    case 5:
                        cr = level - 2;
                        break;
                    case 6:
                        cr = level - 2;
                        break;
                    case 7:
                        cr = level - 2;
                        break;
                    case 8:
                        cr = level - 2;
                        break;
                    case 9:
                        cr = level - 2;
                        break;
                    case 10:
                        cr = level - 2;
                        break;
                    case 11:
                        cr = level - 2;
                        break;
                    case 12:
                        cr = level - 2;
                        break;
                    case 13:
                        cr = level - 2;
                        break;
                    case 14:
                        cr = level - 2;
                        break;
                    case 15:
                        cr = level - 2;
                        break;
                    case 16:
                        cr = level - 2;
                        break;
                    case 17:
                        cr = level - 2;
                        break;
                    case 18:
                        cr = level - 2;
                        break;
                    case 19:
                        cr = level - 2;
                        break;
                    case 20:
                        cr = level - 2;
                        break;

                }
            }
            else if (difficulty == "Deadly")
            {
                switch (level)
                {
                    case 1:
                        cr = 0.5f;
                        break;
                    case 2:
                        cr = level - 1;
                        break;
                    case 3:
                        cr = level - 1;
                        break;
                    case 4:
                        cr = level - 1;
                        break;
                    case 5:
                        cr = level - 1;
                        break;
                    case 6:
                        cr = level - 1;
                        break;
                    case 7:
                        cr = level - 1;
                        break;
                    case 8:
                        cr = level - 1;
                        break;
                    case 9:
                        cr = level - 1;
                        break;
                    case 10:
                        cr = level - 1;
                        break;
                    case 11:
                        cr = level - 1;
                        break;
                    case 12:
                        cr = level - 1;
                        break;
                    case 13:
                        cr = level - 1;
                        break;
                    case 14:
                        cr = level - 1;
                        break;
                    case 15:
                        cr = level - 1;
                        break;
                    case 16:
                        cr = level - 1;
                        break;
                    case 17:
                        cr = level - 1;
                        break;
                    case 18:
                        cr = level - 1;
                        break;
                    case 19:
                        cr = level - 1;
                        break;
                    case 20:
                        cr = level - 1;
                        break;

                }
            }

            return cr;
        }

        /// <summary>
        /// Generate encounter based on 3 inputs
        /// </summary>
        /// <param name="level"></param>
        /// <param name="difficulty"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Creature> Generate(int level, string difficulty, string type)
        {
            float cr = 0;
            foreach (var item in App.Database.GetCreaturesAsync().Result)
            {
                
                if (cr == 0 && creatures.Count == 0)
                {
                    cr = GenerateChallengeRating(level, difficulty) * 3;
                }
                 
                if (item.Type == type)
                {
                    if (item.Challenge_Rating < cr && item.Challenge_Rating < level && item.Challenge_Rating != 0)
                    {
                        creatures.Add(new Creature
                        {
                            Name = item.Name,
                            Type = item.Type,
                            Challenge_Rating = item.Challenge_Rating
                        });
                        cr = cr - item.Challenge_Rating;
                    }
                }
                //if (item.Type == type && item.Challenge_Rating == GenerateChallengeRating(level, difficulty))
                //{
                //    creatures.Add(new Creature
                //    {
                //        Name = item.Name,
                //        Type = item.Type,
                //        Challenge_Rating = item.Challenge_Rating
                //    });
                //}
            }


            rnd = new Random();

            int i = rnd.Next(0, creatures.Count);

            if (creatures.Count == 0)
            {
                creatures.Add(new Creature { Name = "No Creature" });
                return creatures;
            }
            else
            {
                return creatures;
            }
        }
    }
}
