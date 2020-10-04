using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float mSpeed;
    // Calisiyo iste bosver
    void Start()
    {
        mSpeed = 100f;
    }

    // saniyede bi milyon update
    void Update()
    {

        //if (Input.GetKeyDown("space"))
        //{

        //}
        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
    }
}
