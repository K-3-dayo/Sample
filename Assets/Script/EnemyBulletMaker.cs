using UnityEngine;

public class EnemyBulletMaker : MonoBehaviour
{
    //停止しているEnemyが一定時間ごとにBulletを発射するようにします。
    //PlayerがEnemyが発射しているBulletにあたるとゲームが終わるようにします。

    [SerializeField] private GameObject ballet2Prefab;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float balletZ;
    [SerializeField] private float balletX;
    
    private float ranX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
        }
        else
        {


            Instantiate(ballet2Prefab, transform.position, ballet2Prefab.transform.rotation);
            waitTime = 0;
        }
    }
}
