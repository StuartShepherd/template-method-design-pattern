namespace TemplateMethodDesignPattern
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass: BaseOperation1");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass: BaseOperation2");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass: BaseOperation3");
        }

        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        // These are 'hooks'.
        // Subclasses may override them, but it's not mandatory since the hooks already have default (but empty) implementation.
        // Hooks provide additional extension points in some crucial places of the algorithm.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}