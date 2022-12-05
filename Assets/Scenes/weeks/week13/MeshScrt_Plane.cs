using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScrt_Plane : MonoBehaviour
{
    public Vector3[] newvert;
    public int[] newtrian;
    // ���� ���� �ƴ�
    public Texture mainTex;
    // ���� ���� �ƴ�

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

        // ���� ���� �ƴ�
        DefMat.SetTexture("_MainTex", mainTex);
        // ���� ���� �ƴ�

        gameObject.GetComponent<MeshRenderer>().material = DefMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
