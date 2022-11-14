using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SimpleProceduralMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        var mesh = new Mesh
        {
            name = "Procedural Mesh"
        };

        mesh.vertices = new Vector3[] {
            Vector3.zero, // (0,0,0)
            Vector3.right, //(1,0,0)
            Vector3.up  //(0,1,0)
        };

        mesh.normals = new Vector3[] {
            Vector3.back, Vector3.back, Vector3.back
        };

        mesh.triangles = new int[] {
            0, 2, 1
        };


        mesh.uv = new Vector2[] {
            Vector2.zero, Vector2.right, Vector2.up
        };

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
