using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject Enemie1;
    public GameObject Enemie2;
    public Transform enemyPos;
    public Transform enemyPos1;
    //public float repeatRate = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            EnemySpawner();
        }
    }

    void EnemySpawner ()
    {
        Instantiate(Enemie1, enemyPos.position , enemyPos.rotation);
        Instantiate(Enemie2, enemyPos1.position, enemyPos1.rotation);
    }
}
