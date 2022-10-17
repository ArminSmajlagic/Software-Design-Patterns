namespace memento
{
    public class Caretaker
    {
        private Originator originator;
        private List<Memento> history;
        public Caretaker(Originator originator)
        {
            this.originator = originator;
            history = new List<Memento>();
        }
        public void ChangeState()
        {
            var m = originator.CreateMemento();
            history.Add(m);
        }

        public void Undo()=>
            history.RemoveAt(history.Count - 1);

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in history)
            {
                Console.WriteLine(memento.GetName());
            }
        }

    }
}
