namespace prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IDCard Card;

        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)MemberwiseClone();
            clone.Name = Name;
            clone.Card = new IDCard(Card.id);
            return clone;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Name : {0:s}",Name);
            Console.WriteLine("Age : {0:d}", Age);
            Console.WriteLine("Card id : {0:d}", Card.id);
            Console.WriteLine("Birth Date : {0:MM/dd/yy}", BirthDate);

        }
    }

    public class IDCard
    {
        public int id { get; set; }

        public IDCard(int id)
        {
            this.id = id;
        }
    }
}