using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ProceduralGrid : MonoBehaviour {
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    // grid settings
    public float cellSize = 1;
    public Vector3 gridOffset;
    private int gridSizeX;
    private int gridSizeY;

    void Awake () {
        mesh = GetComponent<MeshFilter>().mesh;
	}
	
	void Start () {
        MakeDiscreteProceduralGrid(); // populate the arrays to form our grid
        UpdateMesh(); // set vertices, integers and recalculate nrmls
	}

    void MakeDiscreteProceduralGrid() {
        gridSizeX = Random.Range(1, 5);
        gridSizeY = Random.Range(1, 5);

        // set array sizes
        // need a minimum of 4 vertices to make a quad so multiply gridSize by 4
        vertices = new Vector3[gridSizeX * gridSizeY * 4];

        // need a minimum of 6 lines to make a quad so multiply gridSize by 6
        triangles = new int[gridSizeX * gridSizeY * 6];

        // set tracker integers
        int v = 0;
        int t = 0;

        // set vertex offset so that the origin is in the middle
        float vertexOffset = cellSize * 0.5f;

        // populate the vertices and triangles arrays
        for (int x = 0; x < gridSizeX; x++) {
            for (int y = 0; y < gridSizeY; y++) {
                Vector3 cellOffset = new Vector3(x * cellSize, 0, y * cellSize);

                // add reference to v because once it loops through the first 4 vertices, it'll
                // be time to create a new quad
                // vertexOffset = defines the shape of the cell
                // cellOffset = defines the pos of a single cell
                // gridOffset = defines pos of the entire grid
                vertices[v] = new Vector3(-vertexOffset, 0, -vertexOffset) + cellOffset + gridOffset;
                vertices[v+1] = new Vector3(-vertexOffset, 0, vertexOffset) + cellOffset + gridOffset;
                vertices[v+2] = new Vector3(vertexOffset, 0, -vertexOffset) + cellOffset + gridOffset;
                vertices[v+3] = new Vector3(vertexOffset, 0, vertexOffset) + cellOffset + gridOffset;

                // setting the order to draw the triangles. these are standard to draw
                // a cube
                triangles[t] = v+0;
                triangles[t+1] = v+1;
                triangles[t+2] = v+2;
                triangles[t+3] = v+2;
                triangles[t+4] = v+1;
                triangles[t+5] = v+3;

                v += 4;
                t += 6; 
            }
        }
    }

    void UpdateMesh() {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
