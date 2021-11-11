using System;
using System.Collections.Generic;
using System.Text;
namespace ScoreListUpgrade
{
    public class MarkUpgrader
    {
        public int Upgrade(int oldMark)
        {
            int newMark = 0;
            if (oldMark > 50)
            {
                newMark = oldMark + 5;
            }
            else
            {
                newMark = oldMark + 10;
            }
            //int newMark = oldMark + 5;
            //if (oldMark < 50)
            //    newMark = oldMark + 10;

            return newMark;





        }
    }
}
