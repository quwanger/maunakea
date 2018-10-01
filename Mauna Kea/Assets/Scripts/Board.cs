using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {
	public int[,] board;

	// Use this for initialization
	void Start () {
		board = new int[,] { { 0, 0 }, { 0, 1 }, { 0, 2 } };
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
