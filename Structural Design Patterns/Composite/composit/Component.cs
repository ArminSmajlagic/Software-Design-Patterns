namespace composit
{
    public abstract class Component
    {
        public Component()
        {

        }

        public abstract string Operation();


        //usefull to have children management
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        // This method tells us if component can have children
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
