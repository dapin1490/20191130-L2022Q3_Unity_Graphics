using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tex_Quad : MonoBehaviour
{
    Vector3 V0, V1, V2, V3;
    Vector3[] newvert;
    int[] newtrian;

    public Vector2 UV0, UV1, UV2, UV3;
    Vector2[] newUVs;
    public Texture newtex;

    Mesh mesh;
    Shader DefSha;
    Material DefMat;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Mesh Script - Quad start");

        V0 = new Vector3(0, 0, 0);
        V1 = new Vector3(0, 1, 0);
        V2 = new Vector3(1, 1, 0);
        V3 = new Vector3(1, 0, 0);

        newvert = new Vector3[] { V0, V1, V2, V3 };
        newUVs = new Vector2[] { UV0, UV1, UV2, UV3 };
        newtrian = new int[] {
            0, 1, 2,
            0, 2, 3
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newvert;
        mesh.triangles = newtrian;
        mesh.uv = newUVs;

        DefSha = Shader.Find("Standard");
        DefMat = new Material(DefSha);
        DefMat.mainTexture = newtex;
        gameObject.GetComponent<MeshRenderer>().material = DefMat;

        // 수업 내용 아님
        gameObject.AddComponent<MeshCollider>();
        // 수업 내용 아님
    }

    // Update is called once per frame
    void Update()
    {
        mesh.uv = new Vector2[] { UV0, UV1, UV2, UV3 };
        DefMat.mainTexture = newtex;
        gameObject.GetComponent<MeshRenderer>().material = DefMat;
    }
}
