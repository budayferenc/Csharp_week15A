using System;
using System.Runtime.Serialization;

namespace DemoSerialization
{
    [Serializable]
    class Person : IDeserializationCallback
    {

        // Constructors
        public Person()
        {
        }

        public Person(string Name, DateTime birthDate)
        {
            this.Name = Name;
            this.birthDate = birthDate;
        }

        // Enumeration
        public enum Genders : int { Male, Female };

        // Fields
        public Genders gender;
        private string name;
        [NonSerialized] private DateTime birthDate;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        // Methods
        public string CalculateSomething()
        {
            return "Extra Calculation ";
        }

        public override string ToString()
        {
            return (String.Format("name: {0}, birth date: {1}", this.name, this.birthDate));
        }

        public void OnDeserialization(object sender)
        {
            Name = CalculateSomething() + Name;
        }

    }

}
