using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_speed_controller : MonoBehaviour
{
    Animator anim;
    bool moveVane = false;
    
    // Start is called before the first frame update
    void Start()
    {
        // 초기에 딱 한 번만 실행할 코드
        print("scene start\n");

        anim = GetComponent<Animator>();
        anim.speed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // start 이후 계속 실행할 코드
        print("scene update\n");

        if (Input.GetKeyDown(KeyCode.P))
        {
            print("pressed P\n");
            anim.speed = 1.0f;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            print("pressed S\n");
            anim.speed = 0.0f;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            print("pressed F\n");
            anim.speed = 10.0f;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            print("pressed M\n");
            moveVane = !moveVane;

            if (moveVane)
            {
                print("move vane\n");
                anim.speed = 1.0f;
            }
            else
            {
                print("stop vane\n");
                anim.speed = 0.0f;
            }
        }
    }
}
