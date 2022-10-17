namespace memento
{
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }
        public string GetState() => _state;
        public void SetState(string state)=> _state = state;        
        public string GetName()=>$"\n{DateTime.Now} / {_state.Substring(0, 4)}...";
    }
}
