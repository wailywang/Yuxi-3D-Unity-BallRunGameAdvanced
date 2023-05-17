using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    //����
    public float speedAutoMove = 5;
    public float speedMoveUpAndDown = 5;
    //����
    private void FixedUpdate()
    {
        //С���Զ��˶�
        PlayerAutoMove();

        //С����������ƶ�
        PlayerMoveUpAndDown();

        //С���ٶȿ���
        PlayerMoveMaxSpeed();
    }
    //С���Զ��˶�
    public void PlayerAutoMove()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right*speedAutoMove);
    }
    //С�������˶�
    public void PlayerMoveUpAndDown()
    {
        float v = Input.GetAxis("Vertical");
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speedMoveUpAndDown * v);

    }
    //С���ٶ�����
    public void PlayerMoveMaxSpeed()
    {
        if (gameObject.GetComponent<Rigidbody>().velocity.x > 5)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(5, gameObject.GetComponent<Rigidbody>().velocity.y, 0);
        }
       
    }

}
