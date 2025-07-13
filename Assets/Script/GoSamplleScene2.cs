using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoSamplleScene2 : MonoBehaviour
{
    private ScoreCounter scoreCounterScript;
   [SerializeField]  public static int score;
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
        }
    }
}
