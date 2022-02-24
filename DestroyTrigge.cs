using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemie")
        {
            Destroy(other.gameObject);
        }
    }
}
