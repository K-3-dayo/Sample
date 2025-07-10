using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedY;

    [SerializeField] private float XMax;
    [SerializeField] private float XMin;
    [SerializeField] private float YMax;
    [SerializeField] private float YMin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < XMax)
        {
            transform.Translate(new Vector3(SpeedX, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > XMin)
        {
            transform.Translate(new Vector3(-SpeedX, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && this.transform.position.y < YMax)
        {
            transform.Translate(new Vector3(0, SpeedY, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && this.transform.position.y > YMin)
        {
            transform.Translate(new Vector3(0, -SpeedY, 0) * Time.deltaTime);
        }
    }
}
