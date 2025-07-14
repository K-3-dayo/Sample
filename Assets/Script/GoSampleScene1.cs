
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoSampleScene1 : MonoBehaviour
{
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

            GameObject scoreCounterObject = GameObject.Find("ScoreCounter");
            ScoreCounter scoreCounterScript = scoreCounterObject.GetComponent<ScoreCounter>();
            scoreCounterScript.SetScore(0);
            SceneManager.LoadScene("SampleScene");
        }
    }

}
