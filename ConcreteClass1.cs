namespace TemplateMethodDesignPattern
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1: RequiredOperations1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1: RequiredOperations2");
        }
    }
}