using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour
{
    // 属性
    private float offset;

    //引用
    public GameObject player;
    private void Start()
    {
        offset = gameObject.transform.position.x - player.transform.position.x;
    }

    private void Update()
    {
        //围墙跟随玩家移动
        FollowPlayerMove();
    }

    //跟随玩家运动
    public void FollowPlayerMove()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x + offset, gameObject.transform.position.y, gameObject.transform.position.z) ;
    }
    
}
