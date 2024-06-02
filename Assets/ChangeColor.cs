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
            //�W���ηN����ܥX�ƹ��y�Ц�



        }
        if (Input.GetKeyDown(KeyCode.R))
        //�o�̷N�䬰���U����R�A�NDEBUG �uR��Q���v
        {
            Debug.Log("R was pressed");
            m_Material.color = Color.red; //�o�̪��N�䬰���Ur ����N�ܬ���

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
    private void OnTriggerEnter(Collider other) // �����QRIGID BODR���y�I��ɡA�ۤv�N��ܥ����]�w���C��
    {
        m_Material.color = myColor;
       // transform.parent = other.transform; //�o�y�ηN���y�N�H�A�@�_
    }
    private void OnTriggerExit(Collider other)
    {
        m_Material.color = defaultColor;


    }
}
