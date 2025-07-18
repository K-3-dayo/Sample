using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float initialMakeTime = 5.0f; // 初期生成間隔 (Inspectorで設定)
    [SerializeField] private float minMakeTime = 0.2f;     // 最小生成間隔 (Inspectorで設定)
    [SerializeField] private float speedUpRate = 0.05f;    // 加速レート (Inspectorで設定)

    private float currentMakeTime; // 現在の生成間隔
    private float timer;           // 敵生成のタイマー

    [SerializeField] private float spawnRangeX = 8.0f; // 敵を生成するX軸のランダム範囲 (Inspectorで設定)
    [SerializeField] private float spawnZ = 6.0f;      // 敵を生成するZ座標 (Inspectorで設定)


    void Start()
    {
        currentMakeTime = initialMakeTime; // ゲーム開始時に初期値に設定
        timer = 0; // タイマーをリセット
    }

    void Update()
    {
        // 1. 生成間隔を徐々に短縮する
        currentMakeTime -= speedUpRate * Time.deltaTime;
        currentMakeTime = Mathf.Max(currentMakeTime, minMakeTime);

        // 2. 敵生成のタイマーを更新
        timer += Time.deltaTime;

        // 3. 現在の生成間隔が経過したら敵を生成
        if (timer >= currentMakeTime)
        {
            // ランダムなX座標を計算
            float randomX = Random.Range(-spawnRangeX, spawnRangeX); // -enemyX から +enemyX の範囲

            // 生成位置を設定 (Y座標は0か、敵が地面に着地する高さに調整)
            Vector3 spawnPosition = new Vector3(randomX, 0, spawnZ);
            // もし enemyPrefab 自体のTransformの回転を使いたいなら、最後の引数を enemyPrefab.transform.rotation にする
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity); // 回転はQuaternion.identity (無回転)が一般的

            timer = 0; // タイマーをリセット
        }

       
    }
}