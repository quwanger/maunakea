using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YValue : MonoBehaviour {
    public int yValue;
    public static YValue instance;

    void Awake() {
        instance = this;
    }
	
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
