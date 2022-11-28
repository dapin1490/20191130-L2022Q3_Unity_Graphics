using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Locate : MonoBehaviour
{
    public Transform targetloc;
    Camera targetview;

    // Start is called before the first frame update
    void Start()
    {
        print("UI_Locate script start");
        targetview = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayAtPoint();
    }

    void DisplayAtPoint()
    {
        Vector3 worldpos = targetloc.position + Vector3.up;
        Vector2 screenpos = targetview.WorldToScreenPoint(worldpos);
        transform.position = screenpos;
    }
}
