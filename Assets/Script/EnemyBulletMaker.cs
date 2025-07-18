using UnityEngine;

public class EnemyBulletMaker : MonoBehaviour
{
    //��~���Ă���Enemy����莞�Ԃ��Ƃ�Bullet�𔭎˂���悤�ɂ��܂��B
    //Player��Enemy�����˂��Ă���Bullet�ɂ�����ƃQ�[�����I���悤�ɂ��܂��B

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
