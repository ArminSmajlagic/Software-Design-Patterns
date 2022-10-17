namespace singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private Singleton()
        {
            SpecicificBusenessLogic();
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;

        }

        public void SpecicificBusenessLogic()
        {
            //...
        }
    }
}