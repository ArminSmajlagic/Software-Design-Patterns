namespace mediator
{
    public abstract class Service
    {
        protected IMediator mediator;
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
