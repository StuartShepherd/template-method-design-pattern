using TemplateMethodDesignPattern;

Console.WriteLine("Template Method Design Pattern");
Console.WriteLine("Template Method is a behavioral design pattern that allows you to defines a skeleton of an algorithm in a base class and let subclasses override the steps without changing the overall algorithm’s structure.");
Console.WriteLine();

Console.WriteLine("ConcreteClass1:");
Client.ClientCode(new ConcreteClass1());
Console.WriteLine();

Console.WriteLine("ConcreteClass2:");
Client.ClientCode(new ConcreteClass2());
Console.WriteLine();

Console.WriteLine("ConcreteClass3:");
Client.ClientCode(new ConcreteClass3());
Console.WriteLine();