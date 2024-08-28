using Fruit;
namespace Apple;

public class AddApple:NewFruit
{
    public string color;

public AddApple():this("fhcgyr")
{
    
}
    public AddApple(int Id,string name,string taste,string color):base(Id,name,taste)
    {
          this.color=color;
    }

    public override string ToString()
    {
        return base.ToString()+" Color="+this.color;
    }

    public override void tasteOfFruit()
    {
        Console.WriteLine("Apple's taste is sweet!!!");
    }
}
