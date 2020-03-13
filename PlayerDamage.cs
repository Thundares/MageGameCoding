using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public GameObject RespawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("damage"))
        {
            gameObject.transform.position = RespawnPosition.transform.position;
            Debug.Log("Took 1 Damage");
        }
        else
        {
            Debug.Log(other.gameObject.tag.ToString());
        }
    }
}
