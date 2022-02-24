using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTigger : MonoBehaviour
{
    public GameManger gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.completeLevel();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
