using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_reverse_controller : MonoBehaviour
{
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        print("scene start");
        anim = GetComponent<Animator>();
        anim.SetFloat("direction", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            print("set direction 1");
            anim.SetFloat("direction", 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            print("set direction -1");
            anim.SetFloat("direction", -1.0f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("set direction 0");
            anim.SetFloat("direction", 0.0f);
        }
    }
}
