using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NYUPerson michalshoshan = new NYUStuff();
        michalshoshan.name = "Michalshoshan";
        michalshoshan.age = 33;
        michalshoshan.Nnumber = 123235345;
        michalshoshan.netId = "mbs9316";

        Debug.Log(michalshoshan.GetRecord());
        
        NYUStudent lala = new NYUStudent();
       // lala.gradYear = 2025;
        lala.Nnumber = 123235345;
        lala.netId = "lala123";
        lala.gradYear = 3036;
        
        Debug.Log(lala.GetRecord());
        
        NYUPerson Frenk = new NYUPerson("f42","frenk lantch",62, 122434);
        
        Debug.Log(Frenk.GetRecord());

        NYDog Gemma = new NYDog();
        Gemma.name = "Gemma";
        Gemma.age = 4.5f;
        Gemma.hobbies = "To run after a ball";
        Gemma.location = "Brooklyn";
        
        Debug.Log(Gemma.GetRecord());

        NYPets Lili = new NYDog();
        Lili.name = "Lili";
        Lili.age = 1.5f;
        Lili.hobbies = "To find a stick";
        
        Debug.Log(Lili.GetRecord());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
