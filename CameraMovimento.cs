using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovimento : MonoBehaviour
{

    public GameObject Player;
    private Vector3 Movimento;

    private void Start() 
    {
        Movimento = transform.position - Player.transform.position + new Vector3(0,20,0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + Movimento;
    }
}
