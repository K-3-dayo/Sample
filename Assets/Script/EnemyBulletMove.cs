using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    //Enemy�����˂���Bullet�̓��������߂܂��B

    [SerializeField] private float bulletSpeed = -5;
    [SerializeField] private float bulletLifeTime = 4.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�e���������ꂽ�Ƃ��ɁAlitetime�b��Ɏ��g��j������
        Destroy(gameObject, bulletLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, bulletSpeed) * Time.deltaTime);

        bulletLifeTime = bulletLifeTime - Time.deltaTime;

        if (bulletLifeTime < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
