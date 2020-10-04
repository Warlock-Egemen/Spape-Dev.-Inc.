using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{

    public float fSpeed;

    // Start is called before the first frame update
    void Start()
    {
        fSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject Teleporter = GameObject.Find("ThePlayer");
        //Teleporter teleporter = Teleporter.GetComponent<Teleporter>();

        //if (teleporter.stop == false)
        //{
        if (Input.GetKeyDown("space"))
        {
            fSpeed = 100f;

        }
        transform.position += Vector3.forward * Time.deltaTime * fSpeed;

        //}

        //GameObject Teleporter = GameObject.Find("ThePlayer");
        //Teleporter teleporter = Teleporter.GetComponent<Teleporter>();
        //teleporter.stop = ;
    }
}
