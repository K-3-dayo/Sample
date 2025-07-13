using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float enemySpeed = -5;
    [SerializeField] private float enemyLifeTime;

    private GameObject scoreCounterObject;
    private ScoreCounter scoreCounterScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreCounterObject = GameObject.Find("ScoreCounter");
        scoreCounterScript = scoreCounterObject.GetComponent<ScoreCounter>();
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            scoreCounterScript.ScoreUp();
            Destroy(this.gameObject);
        }
    }
}
