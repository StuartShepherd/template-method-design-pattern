namespace TemplateMethodDesignPattern
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2: RequiredOperations1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2: RequiredOperations2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2: Hook1");
        }
    }
}