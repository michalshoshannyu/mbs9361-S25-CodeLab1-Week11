public class NYUPerson
{
    public string netId;
    public string name;
    
    public float age;
    public long Nnumber;

    //empty constractor for a student that dosnet have all the needed data
    public NYUPerson()
    {
        
    }

    //constractor that takes arguments 
    public NYUPerson(string netId, string name, float age, long Nnumber)
    {
        this.netId = netId;
        this.name = name;
        this.age = age;
        this.Nnumber = Nnumber;
        
    }

    public virtual string GetRecord()
    {
        string result = "Name: " + name + "\nNetId: " + netId + "\nAge: " + age + "\nNNumber: " + Nnumber + "\n";
        
        return result;
    }
}