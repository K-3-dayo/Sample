using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float initialMakeTime = 5.0f; // ���������Ԋu (Inspector�Őݒ�)
    [SerializeField] private float minMakeTime = 0.2f;     // �ŏ������Ԋu (Inspector�Őݒ�)
    [SerializeField] private float speedUpRate = 0.05f;    // �������[�g (Inspector�Őݒ�)

    private float currentMakeTime; // ���݂̐����Ԋu
    private float timer;           // �G�����̃^�C�}�[

    [SerializeField] private float spawnRangeX = 8.0f; // �G�𐶐�����X���̃����_���͈� (Inspector�Őݒ�)
    [SerializeField] private float spawnZ = 6.0f;      // �G�𐶐�����Z���W (Inspector�Őݒ�)


    void Start()
    {
        currentMakeTime = initialMakeTime; // �Q�[���J�n���ɏ����l�ɐݒ�
        timer = 0; // �^�C�}�[�����Z�b�g
    }

    void Update()
    {
        // 1. �����Ԋu�����X�ɒZ�k����
        currentMakeTime -= speedUpRate * Time.deltaTime;
        currentMakeTime = Mathf.Max(currentMakeTime, minMakeTime);

        // 2. �G�����̃^�C�}�[���X�V
        timer += Time.deltaTime;

        // 3. ���݂̐����Ԋu���o�߂�����G�𐶐�
        if (timer >= currentMakeTime)
        {
            // �����_����X���W���v�Z
            float randomX = Random.Range(-spawnRangeX, spawnRangeX); // -enemyX ���� +enemyX �͈̔�

            // �����ʒu��ݒ� (Y���W��0���A�G���n�ʂɒ��n���鍂���ɒ���)
            Vector3 spawnPosition = new Vector3(randomX, 0, spawnZ);
            // ���� enemyPrefab ���̂�Transform�̉�]���g�������Ȃ�A�Ō�̈����� enemyPrefab.transform.rotation �ɂ���
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity); // ��]��Quaternion.identity (����])����ʓI

            timer = 0; // �^�C�}�[�����Z�b�g
        }

       
    }
}