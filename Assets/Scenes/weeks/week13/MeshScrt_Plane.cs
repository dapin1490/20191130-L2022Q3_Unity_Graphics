using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScrt_Plane : MonoBehaviour
{
    public Vector3[] newvert;
    public int[] newtrian;
    // 수업 내용 아님
    public Texture mainTex;
    // 수업 내용 아님

    // Start is called before the first frame update
    void Start()
    {
        print("Mesh Script - Plane start");

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newvert;
        mesh.triangles = newtrian;

        Shader DefSha = Shader.Find("Standard");
        Material DefMat = new Material(DefSha);

        // 수업 내용 아님
        DefMat.SetTexture("_MainTex", mainTex);
        // 수업 내용 아님

        gameObject.GetComponent<MeshRenderer>().material = DefMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
