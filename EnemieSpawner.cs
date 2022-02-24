using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieSpawner : MonoBehaviour
{
    public GameObject Enemie;
    public int PosX;
    public int PosY;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 4)
        {
            PosX = Random.Range(13, -13);
            PosY = Random.Range(-87, -65);
            Instantiate(Enemie, new Vector3(PosX, 4, PosY), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }
}
