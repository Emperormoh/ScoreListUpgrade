using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ScoreListUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldScore = "ScoreLog.txt";
            var upgradedScoreList = "newsccore.txt";





            //File.Create(upgradedScoreList);
            File.WriteAllText(upgradedScoreList, "");


            foreach (var line in File.ReadAllLines(oldScore))
            {
                var dMark = line.Split("-")[1];
                var markUp = new MarkUpgrader();
                var newMark = markUp.Upgrade(Int32.Parse(dMark));
                var newLineContent = line.Split("-")[0] + "-" + newMark;
                File.AppendAllLines(upgradedScoreList, new string[] { newLineContent });
            }





    }   }
}
