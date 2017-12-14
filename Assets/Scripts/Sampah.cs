using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sampah : MonoBehaviour {

    public static GameObject[] sampah = new GameObject[6];

    // Use this for initialization
    void Start () {
        sampah[0] = Resources.Load("Prefabs/apel") as GameObject;
        sampah[1] = Resources.Load("Prefabs/ayam") as GameObject;
        sampah[2] = Resources.Load("Prefabs/botol") as GameObject;
        sampah[3] = Resources.Load("Prefabs/ikan") as GameObject;
        sampah[4] = Resources.Load("Prefabs/plastik") as GameObject;
        sampah[5] = Resources.Load("Prefabs/gelas") as GameObject;
    }
}
