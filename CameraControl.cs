using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //属性
    private float offset;
    //引用
    public GameObject player;

    void Start()
    {
        offset = gameObject.transform.position.x - player.transform.position.x;
    }

    void Update()
    {
        //摄像机跟随运动
        FllowPlayer();
    }
    //摄像机跟随运动
    public void FllowPlayer()
    {
        gameObject.transform.position = new Vector3(offset + player.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

}
