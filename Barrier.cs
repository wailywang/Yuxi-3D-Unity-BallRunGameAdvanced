using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public Material[] barrierMaterials;
    // Start is called before the first frame update
    void Start()
    {
        int i=Random.Range(0, barrierMaterials.Length);
        gameObject.GetComponent<Renderer>().material = barrierMaterials[i];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
