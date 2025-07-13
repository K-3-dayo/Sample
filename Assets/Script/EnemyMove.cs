using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float enemySpeed = -5;
    [SerializeField] private float enemyLifeTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, enemySpeed) * Time.deltaTime);

        enemyLifeTime = enemyLifeTime - Time.deltaTime;

        if (enemyLifeTime < 0 )
        {
            Destroy(this.gameObject);
        }
    }
}
