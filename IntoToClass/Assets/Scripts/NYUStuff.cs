using System.Threading;
using NUnit.Framework.Internal;

public class NYUStuff : NYUPerson
{
    public float salary;

    public NYUStuff()
    {
    }

    public NYUStuff(string netId, string name, float age, long Nnumber,float salary) : base(netId, name, age, Nnumber)
    {
        this.salary = salary;
    }

    public override string GetRecord()
    {
       //return "WTF";
       string result = base.GetRecord();
       return result;
    }
}
