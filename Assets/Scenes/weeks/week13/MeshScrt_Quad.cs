using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScrt_Quad : MonoBehaviour
{
    public Vector3[] newvert;
    public int[] newtrian;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Mesh Script - Quad start");

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newvert;
        mesh.triangles = newtrian;

        Shader DefSha = Shader.Find("Standard");
        Material DefMat = new Material(DefSha);
        gameObject.GetComponent<MeshRenderer>().material = DefMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
