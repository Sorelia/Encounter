using System;
using System.Collections.Generic;
using System.Text;

namespace RandomEncounter.Interfaces
{
    interface IGenerateEncounter
    {
        float GenerateChallengeRating(int level, string difficulty);
        List<Creature> Generate(int level, string difficulty, string type);
        void Clear();
    }
}
