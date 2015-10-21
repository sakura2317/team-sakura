using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour
{
    public float timer = 0;
    public float TransSpeedX = 0.3f;
    public float TransSpeedZ = 0.3f;
    public float JumpPower   = 5.0f;
    public GameObject PlayerObj;

    // Use this for initialization
    void Start()
    {
        Debug.Log("----- デバッグログ：Start() -----");
        StartCoroutine("Coroutines");
        PlayerObj = GameObject.Find("/Player/Player");
        Physics.gravity = new Vector3(0, -21f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("----- デバッグログ：Update() -----");
        timer += Time.deltaTime;
        InputTransA();
        InputTransB();
        InputJump();
    }

    //Action-Move
    public void InputTransA()
    {
        Debug.Log("----- デバッグログ：InputTranslateA() -----");
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKey("up") || Input.GetKey("down")){
            vertical = (float)Math.Pow(vertical, 3);
            transform.Translate(0, 0, vertical * TransSpeedZ);
        }
        if (Input.GetKey("left") || Input.GetKey("right")){
            horizontal = (float)Math.Pow(horizontal, 3);
            transform.Translate(horizontal * TransSpeedX, 0, 0);
        }
    }

    //Action-Move
    public void InputTransB(){
        Debug.Log("----- デバッグログ：InputTranslateB() -----");
        if (Input.GetKey(KeyCode.W)){ transform.Translate(0, 0, TransSpeedZ      );}
        if (Input.GetKey(KeyCode.S)){ transform.Translate(0, 0, (-1)*TransSpeedZ );}
        if (Input.GetKey(KeyCode.D)){ transform.Translate(TransSpeedX     , 0, 0 );}
        if (Input.GetKey(KeyCode.A)){ transform.Translate((-1)*TransSpeedX, 0, 0 );}
    }

    //Action-Jump
    public void InputJump() {
        Debug.Log("----- デバッグログ：InputJump() -----");
        if (Input.GetKeyDown("space"))
        {
            PlayerObj.GetComponent<Rigidbody>().AddForce(Vector3.up * JumpPower  * 1000);
        }
    }

    //Test&Debug-Coroutines
    public IEnumerator Coroutines()
    {
        Debug.Log("----- デバッグログ：Coroutines() -----");
        Debug.Log("timer_" + timer);
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(3.0f);
            Debug.Log("timer_" + timer);
        }
    }


}