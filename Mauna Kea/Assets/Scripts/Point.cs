using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Point
{
	// Define locations of our tiles on our game board. The y coordinate will be the depth
	public int x; 
	public int z;

	// Create a constructor so we can create new points like Point(1,2) instead of assigning
	// each x and z coordinate separately.
	public Point (int x, int z)
	{
		this.x = x;
		this.z = z;
	}
}
