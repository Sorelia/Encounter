using RandomEncounter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomEncounter.Classes
{
    public class Lists : ILists
    {
        List<string> area = new List<string>();
        List<string> type = new List<string>();
        List<string> diff = new List<string>();
        List<int> level = new List<int>();
        /// <summary>
        /// Adds areas to a list
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public List<string> Area()
        {
            if (area.Count == 0)
            {
                area.Add("Cave");
                area.Add("Underdark");
                area.Add("Ocean");
                area.Add("Mountain");
                area.Add("House");
                area.Add("Castle");
                area.Add("City");
                area.Add("Swamp");
            }
            return area;
        }
        /// <summary>
        /// Adds types to a list
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<string> CreatureType()
        {
            if (type.Count == 0)
            {
                foreach (var item in App.Database.GetCreaturesAsync().Result)
                {
                    if (!type.Contains(item.Type))
                    {
                        type.Add(item.Type);
                    }
                }
            }
            return type;
        }
        /// <summary>
        /// adds Difficulties to a list
        /// </summary>
        /// <param name="diff"></param>
        /// <returns></returns>
        public List<string> Difficulty()
        {
            if (diff.Count == 0)
            {
                diff.Add("Easy");
                diff.Add("Medium");
                diff.Add("Hard");
                diff.Add("Deadly");
            }
            return diff;
        }
        /// <summary>
        /// Adds levels to a list
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public List<int> Levels()
        {
            if (level.Count == 0)
            {
                for (int i = 1; i < 21; i++)
                {
                    level.Add(i);
                }
            }
            return level;
        }
    }
}
