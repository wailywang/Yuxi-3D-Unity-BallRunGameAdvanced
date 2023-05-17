using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour
{
    // ����
    private float offset;

    //����
    public GameObject player;
    private void Start()
    {
        offset = gameObject.transform.position.x - player.transform.position.x;
    }

    private void Update()
    {
        //Χǽ��������ƶ�
        FollowPlayerMove();
    }

    //��������˶�
    public void FollowPlayerMove()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x + offset, gameObject.transform.position.y, gameObject.transform.position.z) ;
    }
    
}
