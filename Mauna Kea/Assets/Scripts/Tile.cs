using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
	public int[,] board;
	public float step;
	public int height;

	// Use this for initialization
	void Start () {
		board = new int[,] { 
													{ 0, 0 }, { 0, 1 }, { 0, 2 },
													{ 1, 0 }, { 1, 1 }, { 1, 2 },
													{ 2, 0 }, { 2, 1 }, { 2, 2 }
											 };

		//for (int i = 0; i <= 9; i++)
		//{
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(board[1, 1], 0, board[0, 1]);
		//}

			/*GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube1.transform.position = new Vector3(board[0, 0], 0, board[0, 1]);

			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3(board[1, 0], 0, board[1, 1]);*/


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}