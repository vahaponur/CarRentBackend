using System;
using System.Collections.Generic;
using System.Text;

namespace Business.TestItems
{
    public static class CreditScoreCreator
    {
        public const int MinCreditScore=0;
        public const int MaxCreditScore=1900;
        public static int GetRandomCreditScore(int minCreditScore=MinCreditScore,int maxCreditScore=MaxCreditScore)
        {
            return new Random().Next(minCreditScore, maxCreditScore);
        }
    }
}
