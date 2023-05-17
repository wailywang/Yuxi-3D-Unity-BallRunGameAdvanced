using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    //属性
    public float speedAutoMove = 5;
    public float speedMoveUpAndDown = 5;
    //引用
    private void FixedUpdate()
    {
        //小球自动运动
        PlayerAutoMove();

        //小球控制上下移动
        PlayerMoveUpAndDown();

        //小球速度控制
        PlayerMoveMaxSpeed();
    }
    //小球自动运动
    public void PlayerAutoMove()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right*speedAutoMove);
    }
    //小球上下运动
    public void PlayerMoveUpAndDown()
    {
        float v = Input.GetAxis("Vertical");
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speedMoveUpAndDown * v);

    }
    //小球速度限制
    public void PlayerMoveMaxSpeed()
    {
        if (gameObject.GetComponent<Rigidbody>().velocity.x > 5)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(5, gameObject.GetComponent<Rigidbody>().velocity.y, 0);
        }
       
    }

}
