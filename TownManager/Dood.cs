using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownManager
{
    public class Dood
    {
        public Dood(int i)
        {
            Id = i;
            MaritalStatus = false;
            WorkStatus = false;
            Deceased = false;
            Mother = -1;
            Father = -1;
            Spouse = -1;
        }

        private List<int> children = new List<int>();
        private int pregnant = 0;
        private int trainTime = 0;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public bool MaritalStatus { get; set; }
        public bool WorkStatus { get; set; }
        public bool Deceased { get; set; }
        public string Job { get; set; }
        public int Spouse { get; set; }
        public int Mother { get; set; }
        public int Father { get; set; }
        public string Reason { get; set; }
        public int Month { get; set; }
        public int Criminal { get; set; }

        //Getters
        public List<int> getChildren()
        {
            return children;
        }
        public int getPregnant()
        {
            return pregnant;
        }
        public int getTrainTime()
        {
            return trainTime;
        }

        //Setters
        public void gainChild(int child)
        {
            children.Add(child);
        }
        public void loseChild(int child)
        {
            children.Remove(child);
        }
        public void setPregnant()
        {
            pregnant++;
            if (pregnant == 10)
                pregnant = 0;
        }
        public void setTrainTime(int t)
        {
            trainTime += t;
            if (trainTime <= 0)
                trainTime = 0;
        }
    }
}
