using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedZ;

    [SerializeField] private float XMax;
    [SerializeField] private float XMin;
    [SerializeField] private float ZMax;
    [SerializeField] private float ZMin;
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
        if (Input.GetKey(KeyCode.W) && this.transform.position.z < ZMax)
        {
            transform.Translate(new Vector3(0, 0, SpeedZ) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && this.transform.position.z > ZMin)
        {
            transform.Translate(new Vector3(0, 0, -SpeedZ) * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("Bullet2"))
        {

            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("Result");
    }
}
