using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierControl : MonoBehaviour
{   //����
    public float barrierInterval = 5;
    //����
    public GameObject player;
    public GameObject CurrentBarrier;
    public GameObject barrierPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�ϰ��Զ�����
        AutoCreateBarriers();
    }
    //�ϰ��Զ�����
    public void AutoCreateBarriers()
    {
        if (player.transform.position.x > CurrentBarrier.transform.position.x)
        {
            //��������
            UIControl._instance.AddScore(5);


            //�����µ��ϰ�
            float targetX = CurrentBarrier.transform.position.x + barrierInterval;
            float targetY = RandomBarrierPosition();
            Vector3 targetPos = new Vector3(targetX, targetY, 0);
            GameObject g = Instantiate(barrierPrefab, targetPos,Quaternion.identity);
            //�����С
            g.transform.localScale = new Vector3(g.transform.localScale.x, RandomBarrierSize((int)g.transform.localScale.y), g.transform.localScale.z);
            
            //�ж��ϰ�����
            CurrentBarrier = g;
        }
    }

    //�ϰ������С
    public float RandomBarrierSize(int r)
    {
        
        int rAbs = Mathf.Abs(r);

        if (rAbs == 0)
        {
            return Random.Range(1,8);
        }
        else
        {
            return Random.Range(1,((4 - rAbs) * 2 + 1));
        }
    }

    //�ϰ����λ��
    public float RandomBarrierPosition()
    {
        int r = Random.Range(-4, 5);
        return r;
        
    }
}
