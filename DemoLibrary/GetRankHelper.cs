using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class GetRankHelper
    {

        public static int GetRank(int coins)
        {
            List<PersonModel> people = new List<PersonModel>();

            people = SqliteDataAccess.LoadPeople();

            if (coins <= people[9].Score)
            {
                return 11; 
            }
            else if(coins > people[9].Score && coins <= people[8].Score)
            {
                return 10;
            }
            else if (coins > people[8].Score && coins <= people[7].Score)
            {
                return 9;
            }
            else if (coins > people[7].Score && coins <= people[6].Score)
            {
                return 8;
            }
            else if (coins > people[6].Score && coins <= people[5].Score)
            {
                return 7;
            }
            else if (coins > people[5].Score && coins <= people[4].Score)
            {
                return 6;
            }
            else if (coins > people[4].Score && coins <= people[3].Score)
            {
                return 5;
            }
            else if (coins > people[3].Score && coins <= people[2].Score)
            {
                return 4;
            }
            else if (coins > people[2].Score && coins <= people[1].Score)
            {
                return 3;
            }
            else if (coins > people[1].Score && coins <= people[0].Score)
            {
                return 2;
            }
            else if (coins > people[0].Score)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        public  static int GetLastId()
        {
            List<PersonModel> people = new List<PersonModel>();

            people = SqliteDataAccess.LoadPeople();

            return people[9].Id;
        }

    }
}
