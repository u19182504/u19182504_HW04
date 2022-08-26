using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19182504_HW04.myModels
{
    public abstract class Citizen
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public int _nationalID { get; set; }
        public string _city { get; set; }
        public virtual string _citizenType { get; set; }

        public Citizen() { }
        public Citizen(string firstName, string lastName, int nationalID, string city, string citizenType)
        {
            _firstName = firstName;
            _lastName = lastName;
            _nationalID = nationalID;
            _city = city;
            _citizenType = citizenType;
        }

        public abstract int travelID();

        public virtual string citizenIdentity()
        {
            return _lastName + " " + _firstName + " is a " + _citizenType + " of "  + _city + " with national identification number " + _nationalID;
        }
    }
}