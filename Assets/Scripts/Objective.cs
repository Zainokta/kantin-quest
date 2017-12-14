using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour {

    public static Vector3[] chair = new Vector3[13];
	// Use this for initialization
	void Start () {
		for(int i = 1; i <= 12; i++)
        {
            chair[i] = GameObject.Find("Chair" + i).transform.position;
        }
	}
}
