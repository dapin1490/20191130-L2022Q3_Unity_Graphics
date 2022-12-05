using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScrt_Cube_Normal : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7;
    Vector3[] newvert;
    int[] newtrian;
    Vector3[] newnormal;

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

        newvert = new Vector3[] {
            // Back
            V0, V4, V7, V3, //0, 1, 2, 3
            // Right
            V3, V7, V6, V2, //4, 5, 6, 7
            // Front
            V2, V6, V5, V1, //8, 9, 10, 11
            // Left
            V1, V5, V4, V0, //12, 13, 14, 15
            // Top
            V4, V5, V6, V7, //16, 17, 18, 19
            // Bottom
            V0, V1, V2, V3 //20, 21, 22, 23
        };

        newtrian = new int[] {
            // Back
            0, 1, 2,
            0, 2, 3,
            // Right
            4, 5, 7,
            7, 5, 6,
            //4, 5, 6,
            //4, 6, 7,
            // Front
            8, 9, 11,
            11, 9, 10,
            // Left
            12, 13, 14,
            12, 14, 15,
            // Top
            16, 17, 18,
            16, 18, 19,
            // Bottom
            21, 20, 23,
            21, 23, 22
        };

        Vector3 Up = Vector3.up;
        Vector3 Down = Vector3.down;
        Vector3 Front = Vector3.forward;
        Vector3 Left = Vector3.left;
        Vector3 Right = Vector3.right;
        Vector3 Back = Vector3.back;

        newnormal = new Vector3[]
        {
            // Back
            Back, Back, Back, Back,
            // Right
            Right, Right, Right, Right,
            // Front
            Front, Front, Front, Front,
            // Left
            Left, Left, Left, Left,
            // Top
            Up, Up, Up, Up,
            // Bottom
            Down, Down, Down, Down
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newvert;
        mesh.triangles = newtrian;
        mesh.normals = newnormal;

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
