using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //¿Û³ý·ÖÊý
        UIControl._instance.AddScore(-3);


        gameObject.GetComponent<Renderer>().material.color = Color.red;
       
    }
  
    private void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
