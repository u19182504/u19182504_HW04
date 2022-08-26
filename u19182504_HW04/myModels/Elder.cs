using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19182504_HW04.myModels
{
    public class Elder : Citizen
    {
        public string _transportType { get; set; }
        public string _disabilities { get; set; }

        public Elder() { }

        public Elder(int distance, string transportType, string disabilities, string firstName, string lastName, int nationalID, string city, string citizenType) : base(firstName, lastName, nationalID, city, citizenType)
        {
            _transportType = transportType;
            _disabilities = disabilities;
        }
        public override int travelID()
        {
            Random random = new Random();
            int five = random.Next(10000, 100000);
            return (five);
        }

        public override string citizenIdentity()
        {
            return base.citizenIdentity() + "They have access to " + _transportType + " transportation with travelID e22" + travelID();
        }
    }
}
