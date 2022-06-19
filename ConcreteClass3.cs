namespace TemplateMethodDesignPattern
{
    public class ConcreteClass3 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass3: RequiredOperations1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass3: RequiredOperations2");
        }

        protected override void Hook2()
        {
            Console.WriteLine("ConcreteClass3: Hook2");
        }
    }
}