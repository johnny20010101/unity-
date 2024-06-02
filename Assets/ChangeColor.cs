using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Material m_Material;
    public Color myColor;
    public Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material; //
        defaultColor = Color.white;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.mousePosition);
            //上面用意為顯示出滑鼠座標位



        }
        if (Input.GetKeyDown(KeyCode.R))
        //這裡意思為按下按鍵R，將DEBUG 「R鍵被按」
        {
            Debug.Log("R was pressed");
            m_Material.color = Color.red; //這裡的意思為按下r 物件將變紅色

        }
        
        if (Input.GetKeyDown(KeyCode.G))

        {
            Debug.Log("G was pressed");
            m_Material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))

        {
            Debug.Log("B was pressed");
            m_Material.color = Color.blue;
        }
    }
    private void OnTriggerEnter(Collider other) // 當本身被RIGID BODR的球碰到時，自己將顯示本身設定的顏色
    {
        m_Material.color = myColor;
       // transform.parent = other.transform; //這句用意為球將黏再一起
    }
    private void OnTriggerExit(Collider other)
    {
        m_Material.color = defaultColor;


    }
}
