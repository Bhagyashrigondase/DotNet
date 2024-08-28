using Fruit;
using Apple;

Console.WriteLine("******Fruit Basket******");
//NewFruit f1=new NewFruit(1,"Orange","Sweet");

NewFruit f1=new AddApple();
NewFruit a1=new AddApple(1,"Apple","Sour","Red");
a1.tasteOfFruit();
Console.WriteLine(f1);
Console.WriteLine(a1);


