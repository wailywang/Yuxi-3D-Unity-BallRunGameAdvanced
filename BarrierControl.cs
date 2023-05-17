using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierControl : MonoBehaviour
{   //属性
    public float barrierInterval = 5;
    //引用
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
        //障碍自动生成
        AutoCreateBarriers();
    }
    //障碍自动生成
    public void AutoCreateBarriers()
    {
        if (player.transform.position.x > CurrentBarrier.transform.position.x)
        {
            //分数增加
            UIControl._instance.AddScore(5);


            //生成新的障碍
            float targetX = CurrentBarrier.transform.position.x + barrierInterval;
            float targetY = RandomBarrierPosition();
            Vector3 targetPos = new Vector3(targetX, targetY, 0);
            GameObject g = Instantiate(barrierPrefab, targetPos,Quaternion.identity);
            //随机大小
            g.transform.localScale = new Vector3(g.transform.localScale.x, RandomBarrierSize((int)g.transform.localScale.y), g.transform.localScale.z);
            
            //判断障碍更换
            CurrentBarrier = g;
        }
    }

    //障碍随机大小
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

    //障碍随机位置
    public float RandomBarrierPosition()
    {
        int r = Random.Range(-4, 5);
        return r;
        
    }
}
