using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    //public bool stop=false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        //stop = true;
        col.transform.position = new Vector3(0, 0, -684);


        //GameObject Forward= GameObject.Find("ThePlayer");
        //Forward forward = Forward.GetComponent<Forward>();
        //forward.fSpeed = 0f;

        //GameObject.Find("fspeed").GetComponent<Forward>().fspeed = 10f;


    }


}
