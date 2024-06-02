using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * Time.deltaTime);

        if (Input.GetKey(KeyCode.F))
            transform.Translate(Vector3.forward * Time.deltaTime);

        if (Input.GetKey(KeyCode.B))
            transform.Translate(Vector3.back * Time.deltaTime);


    }
}
