using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;








public class MyClass
{

    public int age;
    public string name = string.Empty;
    public void GrowUp()
    { 

        age++; //age = age +1;


        }

    public int GrowUpWithReturn()
    {

        age++; //age = age +1;
        return age;



    }

    public string ChangeName(string newName)

    {
        name = newName;
        return name; 
    
    
    
    
    }


}




public class myclass0414 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        MyClass myClass = new MyClass();
        myClass.age = 10;
        myClass.name = "johnny";
        Debug.Log(myClass.age);
        Debug.Log(myClass.name);

        myClass.GrowUp();
        int returnAge = myClass.GrowUpWithReturn();

        Debug.Log(returnAge);



        myClass.name = "jake";
        Debug.Log(myClass.age);
        Debug.Log(myClass.name);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
