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

        public string Name { get => name; set => name = value; }
        public string Grade { get => grade; set => grade = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Hall { get => hall; set => hall = value; }
        public string Room { get => room; set => room = value; }
        public string Religion { get => religion; set => religion = value; }
        public string Race { get => race; set => race = value; }
        public int Relationship { get => relationship; set => relationship = value; }
        public string CruInfo { get => cruInfo; set => cruInfo = value; }
        public string Convo { get => convo; set => convo = value; }

        public Contact(string name, string grade, string gender, string hall, string room, string religion, string race, int relationship, string cruInfo, string convo)
        {
            this.Name = name;
            this.Grade = grade;
            this.Gender = gender;
            this.Hall = hall;
            this.Room = room;
            this.Religion = religion;
            this.Race = race;
            this.Relationship = relationship;
            this.CruInfo = cruInfo;
            this.Convo = convo;
        }
    }
}
