using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    Rigidbody2D playerRB;

    //variaveis para controlar se um botão foi pressionado
    bool upPressed;
    bool downPressed;
    bool rightPressed;
    bool leftPressed;

    [Header("Player Public Variables")]
    public int vida;
    public int energia;
    public int forca;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        upPressed = false;
        downPressed = false;
        rightPressed = false;
        leftPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(energia>0) //com energia
        {
            //setting if pressed
            if(Input.GetAxis("Vertical")>0)
                upPressed = true;
            if(Input.GetAxis("Horizontal")>0)
                rightPressed = true;
            if(Input.GetAxis("Horizontal")<0)
                leftPressed = true;
            if(Input.GetAxis("Vertical")<0)
                downPressed = true;

            //reseting if not pressed
            if(Input.GetAxis("Vertical")==0)
            {
                upPressed = false;
                downPressed = false;
            }
            if(Input.GetAxis("Horizontal")==0)
            {
                rightPressed = false;
                leftPressed = false;
            }
            if(Input.GetAxis("Horizontal")==0 && Input.GetAxis("Vertical")==0)
            {
                energia++;
            }
        }
        else //sem energia
        {
            rightPressed = false;
            leftPressed = false;
            upPressed = false;
            downPressed = false;
            energia++;
        }


    }

    private void FixedUpdate() 
    {
        if(upPressed)
        {
            playerRB.AddForce(transform.up * forca);
            energia--;
        }
        if(downPressed)
        {
            playerRB.AddForce(-transform.up * forca);
            energia--;
        }
        if(rightPressed)
        {
            playerRB.AddForce(transform.right * forca);
            energia--;
        }
        if(leftPressed)
        {
            playerRB.AddForce(-transform.right * forca);
            energia--;
        }
    }

}
