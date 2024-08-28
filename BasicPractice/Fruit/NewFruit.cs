namespace Fruit;

public abstract class NewFruit
{
    public int Id {get; set;}
    public string name {get; set;}
    public string taste{get; set;}

    public NewFruit():this(999,"AAAAA","jehbdwhj");
    {
        
    }

    //Constructor
    public NewFruit(int Id,string name,string taste)
    {
        this.Id=Id;
        this.name=name;
        this.taste=taste;
    }

    public abstract void tasteOfFruit();

    public override string ToString()
    {
        return "Fruit id:"+this.Id+" Name: "+this.name+" Taste:"+this.taste;
    }
}
