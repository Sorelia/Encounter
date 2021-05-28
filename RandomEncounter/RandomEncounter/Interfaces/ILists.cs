using System;
using System.Collections.Generic;
using System.Text;

namespace RandomEncounter.Interfaces
{
    /// <summary>
    /// interface for AddToLists Class
    /// </summary>
    interface ILists
    {
        List<int> Levels();
        List<string> Difficulty();
        List<string> CreatureType();
        List<string> Area();
    }
}
