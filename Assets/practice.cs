using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class practice : MonoBehaviour


{
    public  int myint = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        //�H�UDebug.Log("Hello World! "); �u�X�{//�ɡA���䬰���O�B���Ѫ��N��A�B���|�Q�sĶ�������禡�v
        Debug.Log("Hello World! ");

        /* 

         ��X�{�u/*�P* /�v�ɡA�N���Y�������������r�B�Ʀr�������O�P����

         */
        int a = 0;
        Debug.Log("�o�̪�a������" + a);
        int b = 0;
        Debug.Log("b=" + b);
        //�H�W���u"a="�v��X�{���޸��ɡA���޸����Ҭ��r��

        float c = 2.3f;
        //�H�W��float �i�ŧi�p���I�A�B���b�ȫ᭱�[�@��f�A�Ө禡�~�|����

        var d = 0;
        var e = 2.3f;
        //�ϥ�var�ɡA���O�N�Ѧۤv�ᤩ���ȨӰ��]�w



               //private myint = 10; //private �p�H protected �O�@ public���}�A�䤤public�i��F��bunity�Q�ݨ�

        if (myint == 10)
        {

            Debug.Log("true");

        }
        else
        {

            Debug.Log("false");

        }
        // // myint==10 �P�_��
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
