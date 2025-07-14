using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int score;

    public void ScoreUp()
    {
        score = score + 1;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int value)
    {
        score = value;
        return; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
