using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petalSpeedControl : MonoBehaviour
{
    Animator anim;
    bool stopSpin = false;
    float ps;

    // Start is called before the first frame update
    void Start()
    {
        print("petal speed control start");
        anim = GetComponent<Animator>();
        anim.SetFloat("petalDirection", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("set petal speed 1");
            anim.SetFloat("petalDirection", 1f);
        }
        else if (Input.GetKey(KeyCode.P) && Input.GetKeyDown(KeyCode.Alpha0))
        {
            print("set petal speed 0");
            anim.SetFloat("petalDirection", 0.0f);
        }
        else if (Input.GetKey(KeyCode.P) && Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("set petal speed 2");
            anim.SetFloat("petalDirection", 2.0f);
        }
        else if (Input.GetKey(KeyCode.P) && Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("petal speed up");
            ps = anim.GetFloat("petalDirection");
            anim.SetFloat("petalDirection", ps + 1f);
        }
        else if (Input.GetKey(KeyCode.P) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("petal speed down");
            ps = anim.GetFloat("petalDirection");
            anim.SetFloat("petalDirection", ps - 1f);
        }
        else if (Input.GetKey(KeyCode.P) && 
            (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)))
        {
            print("petal spin reverse");
            ps = anim.GetFloat("petalDirection");
            anim.SetFloat("petalDirection", ps * -1f);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            stopSpin = !stopSpin;
            if (stopSpin)
            {
                print("petal stop");
                ps = anim.GetFloat("petalDirection");
                anim.SetFloat("petalDirection", 0f);
            }
            else
            {
                print("petal spin");
                anim.SetFloat("petalDirection", ps);
            }
        }
    }
}
