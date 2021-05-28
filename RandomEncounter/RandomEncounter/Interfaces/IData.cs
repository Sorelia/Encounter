using System;
using System.Collections.Generic;
using System.Text;

namespace RandomEncounter.Interfaces
{
    interface IData
    {
        string FillDB(List<Creature> creatures);
        List<Creature> CheckDB();
        Creature FromCSV(string csvLine);
    }
}
