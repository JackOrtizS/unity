using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidad = 0f;
    public GameObject obj1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");

        float s = Input.GetAxis("Jump");


        Vector3 movimiento = new Vector3(mh, s, mv);

        transform.Translate(movimiento * velocidad * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(obj1, transform.position + transform.forward, Quaternion.identity);
        }
    }
}