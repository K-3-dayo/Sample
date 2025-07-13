using UnityEngine;
using UnityEngine.UI;

public class ScoreUIPresenter : MonoBehaviour
{
    private GameObject scoreCounterObject;
    private ScoreCounter scoreCounterScript;
    private Text mytext;

    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreCounterObject = GameObject.Find("ScoreCounter");
        scoreCounterScript = scoreCounterObject.GetComponent<ScoreCounter>();
        mytext = GetComponent<Text>();
        score = scoreCounterScript.GetScore();
        mytext.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
