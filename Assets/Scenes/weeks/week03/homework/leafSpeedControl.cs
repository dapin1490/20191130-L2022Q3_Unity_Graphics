using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafSpeedControl : MonoBehaviour
{
    Animator anim;
    bool stopSpin = false;
    float ls;
    
    // Start is called before the first frame update
    void Start()
    {
        print("leaf speed control start");
        anim = GetComponent<Animator>();
        anim.SetFloat("leafDirection", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L) && Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("set leaf speed 1");
            anim.SetFloat("leafDirection", 1f);
        }
        else if (Input.GetKey(KeyCode.L) && Input.GetKeyDown(KeyCode.Alpha0))
        {
            print("set leaf speed 0");
            anim.SetFloat("leafDirection", 0.0f);
        }
        else if (Input.GetKey(KeyCode.L) && Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("set leaf speed 2");
            anim.SetFloat("leafDirection", 2.0f);
        }
        else if (Input.GetKey(KeyCode.L) && Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("leaf speed up");
            ls = anim.GetFloat("leafDirection");
            anim.SetFloat("leafDirection", ls + 1f);
        }
        else if (Input.GetKey(KeyCode.L) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("leaf speed down");
            ls = anim.GetFloat("leafDirection");
            anim.SetFloat("leafDirection", ls - 1f);
        }
        else if (Input.GetKey(KeyCode.L) &&
            (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)))
        {
            print("leaf spin reverse");
            ls = anim.GetFloat("leafDirection");
            anim.SetFloat("leafDirection", ls * -1f);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            stopSpin = !stopSpin;
            if (stopSpin)
            {
                print("leaf stop");
                ls = anim.GetFloat("leafDirection");
                anim.SetFloat("leafDirection", 0f);
            }
            else
            {
                print("leaf spin");
                anim.SetFloat("leafDirection", ls);
            }
        }
    }
}
