namespace composit
{
    public class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override string Operation()
        {
            var result = "\nBranch has leafs : ";

            foreach (var child in _children)
            {
                result += child.Operation()+" ";
            }
            return result+"\n";
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
    }
}
