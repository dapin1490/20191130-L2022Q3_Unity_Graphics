using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScrt_Diamond : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5;
    Vector3[] newvert;
    int[] newtrian;
    // 수업 내용 아님
    public Texture mainTex;
    //float[] color_code = { 1f, 1f, 1f, 1f };
    //Color[] colors = { Color.black, Color.blue, Color.clear, Color.cyan, Color.gray, Color.green, Color.grey, Color.magenta, Color.red, Color.white, Color.yellow };
    // 수업 내용 아님

    // Start is called before the first frame update
    void Start()
    {
        print("Mesh Script - Pyramid start");

        V0 = new Vector3(-0.5f, 0, -0.5f);
        V1 = new Vector3(-0.5f, 0, 0.5f);
        V2 = new Vector3(0.5f, 0, 0.5f);
        V3 = new Vector3(0.5f, 0, -0.5f);
        V4 = new Vector3(0, 1, 0);
        V5 = new Vector3(0, -1, 0);

        newvert = new Vector3[] { V0, V1, V2, V3, V4, V5 };
        newtrian = new int[] {
            0, 4, 3,
            3, 4, 2,
            2, 4, 1,
            1, 4, 0, // 여기까지 윗부분
            0, 3, 5,
            3, 2, 5,
            2, 1, 5,
            1, 0, 5
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newvert;
        mesh.triangles = newtrian;

        Shader DefSha = Shader.Find("Standard");
        Material DefMat = new Material(DefSha);

        gameObject.GetComponent<MeshRenderer>().material = DefMat;
        
        // 수업 내용 아님
        gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", mainTex);
        gameObject.AddComponent<MeshCollider>();
        // 수업 내용 아님
    }

    // Update is called once per frame
    void Update()
    {
        // 수업 내용 아님
        if (Random.Range(1, 121) % 30 == 0)
        {
            // gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", colors[++c_index % colors.Length]);
            gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",
                new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)));
        }
        // 수업 내용 아님
    }
}
