using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class practice : MonoBehaviour


{
    public  int myint = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        //以下Debug.Log("Hello World! "); 「出現//時，左邊為筆記、註解的意思，且不會被編譯器視為函式」
        Debug.Log("Hello World! ");

        /* 

         當出現「/*與* /」時，代表頭尾之內的任何文字、數字接為筆記與註解

         */
        int a = 0;
        Debug.Log("這裡的a值應該" + a);
        int b = 0;
        Debug.Log("b=" + b);
        //以上為「"a="」當出現雙引號時，雙引號內皆為字串

        float c = 2.3f;
        //以上為float 可宣告小數點，且須在值後面加一個f，該函式才會成立

        var d = 0;
        var e = 2.3f;
        //使用var時，型別將由自己賦予的值來做設定



               //private myint = 10; //private 私人 protected 保護 public公開，其中public可能東西在unity被看到

        if (myint == 10)
        {

            Debug.Log("true");

        }
        else
        {

            Debug.Log("false");

        }
        // // myint==10 判斷式
        // //myint>10
        // //myint < 10
        // //myint>=10
        // //myint<=10









    }

    // Update is called once per frame
    void Update()
    {

    }
}
