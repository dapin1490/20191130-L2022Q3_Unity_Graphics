using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScrt_Cube : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7;
    Vector3[] newvert;
    int[] newtrian;

    // 빛 렌더링
    Mesh mesh;

    // 수업 내용 아님
    float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        V0 = new Vector3(-0.5f, -0.5f, -0.5f);
        V1 = new Vector3(-0.5f, -0.5f, 0.5f);
        V2 = new Vector3(0.5f, -0.5f, 0.5f);
        V3 = new Vector3(0.5f, -0.5f, -0.5f);
        V4 = new Vector3(-0.5f, 0.5f, -0.5f);
        V5 = new Vector3(-0.5f, 0.5f, 0.5f);
        V6 = new Vector3(0.5f, 0.5f, 0.5f);
        V7 = new Vector3(0.5f, 0.5f, -0.5f);

        newvert = new Vector3[] { V0, V1, V2, V3, V4, V5, V6, V7 };
        newtrian = new int[]
        {
            // Back
            0, 4, 7,
            0, 7, 3,
            // Left
            3, 7, 2,
            2, 7, 6,
            // Front
            1, 6, 5,
            1, 2, 6,
            // Right
            1, 4, 0,
            1, 5, 4,
            // Top
            4, 5, 6,
            4, 6, 7,
            // Bottom
            1, 0, 3,
            1, 3, 2
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

        // 빛 렌더링
        mesh = GetComponent<MeshFilter>().mesh;
        print(mesh.name);
        print(mesh.vertices);
        int counter = 0;
        foreach (Vector3 vextex in mesh.vertices)
        {
            print(counter + ", " + vextex);
            counter++;
        }

        // 수업 내용 아님
        gameObject.AddComponent<MeshCollider>();
        // 수업 내용 아님
    }

    // Update is called once per frame
    void Update()
    {
        // 수업 내용 아님
        if (Random.Range(1, 121) % 30 == 0)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",
                new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)));
        }

        // 참고 : https://docs.unity3d.com/kr/530/ScriptReference/Mesh-normals.html
        // obtain the normals from the mesh
        Vector3[] normals = mesh.normals;

        // edit the normals in an external array
        Quaternion rotation = Quaternion.AngleAxis(Time.deltaTime * speed, Vector3.up);
        for (int i = 0; i < normals.Length; i++)
            normals[i] = rotation * normals[i];

        // assign the array of normals to the mesh
        mesh.normals = normals;
        // 수업 내용 아님
    }
}
