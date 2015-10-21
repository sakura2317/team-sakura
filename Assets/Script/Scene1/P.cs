using UnityEngine;
using System;

public class P : MyTransPosition
{
    public float TransSpeedX = 0.3f;
    public float TransSpeedZ = 0.3f;
    public GameObject PlayerObj;

    // Use this for initialization
    void Start ()
	{
        PlayerObj = GameObject.Find("Cube");
        Physics.gravity = new Vector3(0, -21f, 0);
    }

    // Update is called once per frame
    void Update ()
	{
        InputTransA();
        Debug.Log(PositionZ);
        Debug.Log(Position);

        PositionZ = 0.001f;
        PlayerObj.transform.Translate(0,0,PositionZ);

    }

    //Action-Move
    public void InputTransA()
    {
        Debug.Log("----- デバッグログ：InputTranslateA() -----");
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKey("up") || Input.GetKey("down"))
        {
            vertical = (float)Math.Pow(vertical, 3);
            transform.Translate(0, 0, vertical * TransSpeedZ);
        }
        if (Input.GetKey("left") || Input.GetKey("right"))
        {
            horizontal = (float)Math.Pow(horizontal, 3);
            transform.Translate(horizontal * TransSpeedX, 0, 0);
        }
    }

}