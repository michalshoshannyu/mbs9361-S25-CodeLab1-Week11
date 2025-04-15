using UnityEngine;
public class NYUStudent: NYUPerson
{

    public int gradYear;

    public NYUStudent()
    {
        
    }

    public NYUStudent(string netId, string name, float age, long Nnumber, int gradYear) : base(netId, name, age, Nnumber)
    {
        this.gradYear = gradYear;
    }
}
