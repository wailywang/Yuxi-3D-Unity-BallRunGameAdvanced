using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //����
    private float offset;
    //����
    public GameObject player;

    void Start()
    {
        offset = gameObject.transform.position.x - player.transform.position.x;
    }

    void Update()
    {
        //����������˶�
        FllowPlayer();
    }
    //����������˶�
    public void FllowPlayer()
    {
        gameObject.transform.position = new Vector3(offset + player.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

}
