
using Unity.VisualScripting
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoSampleScene1 : MonoBehaviod
    private ScoreCounter scoreCounterScript;

    [SerializeField] public static int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
            ScoreCounter.score = 0;
            GameObject scoreCounterObject = GameObject.Find("ScoreCounter");
            ScoreCounter scoreCounterScript = scoreCounterObject.GetComponent<ScoreCounter>();
            scoreCounterScript.SetScore(0);
            SceneManager.LoadScene("SampleScene");
        }
    }

}
