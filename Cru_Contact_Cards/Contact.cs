using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cru_Contact_Cards
{
    class Contact
    {
        private string name;
        private string grade;
        private string gender;
        private string hall;
        private string room;
        private string religion;
        private string race;
        private int relationship;
        private string cruInfo;
        private string convo;

        public Contact(string name, string grade, string gender, string hall, string room, string religion, string race, int relationship, string cruInfo, string convo)
        {
            this.name = name;
            this.grade = grade;
            this.gender = gender;
            this.hall = hall;
            this.room = room;
            this.religion = religion;
            this.race = race;
            this.relationship = relationship;
            this.cruInfo = cruInfo;
            this.convo = convo;
        }

        public string getHall()
        {
            return hall;
        }
    }
}
