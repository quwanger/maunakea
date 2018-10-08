using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ProceduralMesh : MonoBehaviour {
    Mesh mesh;

    // vertices are the points of our triangle
    Vector3[] vertices;

    // triangles will tell us in what order to draw the lines
    int[] triangles;

    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    void Update () {
        MakeMeshData();
        CreateMesh();
	}

    void MakeMeshData() {
        // create an array of vertices
        vertices = new Vector3[] { new Vector3(0, YValue.instance.yValue, 0), new Vector3(0, 0, 1), new Vector3(1, 0, 0), new Vector3(1, 0, 1) };

        //create an array of integers
        triangles = new int[] { 0, 1, 2, 2, 1, 3 };
    }

    void CreateMesh() {
        // clear any existing mesh data
        mesh.Clear();

        // store the newly created triangle into the mesh filter component of the object
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }
}
