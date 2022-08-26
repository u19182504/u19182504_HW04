using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19182504_HW04.myModels
{
    public class Scholar : Citizen
    {
        public int _distance { get; set; }
        public string _transportType { get; set; }

        public Scholar() { }

        public Scholar(int distance, string transportType, string firstName, string lastName, int nationalID, string city, string citizenType) :base(firstName, lastName, nationalID, city, citizenType)
        {
            _distance = distance;
            _transportType = transportType;
        }

        public override int travelID()
        {
            Random random = new Random();
            int five = random.Next(10000, 100000);
            return (five);
        }

        public override string citizenIdentity()
        {
            return base.citizenIdentity() + /*"They have access to " + _transportType + " transportation travelling within a " + _distance +*/ "km radius with travelID s22" + travelID();
        }
    }
}