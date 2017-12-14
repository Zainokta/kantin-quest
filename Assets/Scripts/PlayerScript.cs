using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerScript : MonoBehaviour {

    private Transform agentPos;
    
    private float yOffset = 5.08f;
    private float offset = -1.25f;
    
    public static int indexSampah;

	// Use this for initialization
	void Start ()
    {
        agentPos = FindObjectOfType<AgentScript>().transform;
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        transform.localPosition = new Vector3(agentPos.localPosition.x, agentPos.localPosition.y - yOffset, agentPos.localPosition.z);
        indexSampah = Random.Range(0, 6);
	}

    public void Action()
    {
        Instantiate(Sampah.sampah[indexSampah], new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z - offset), Quaternion.Euler(90,0,0)).transform.parent = GameManager.instance.parentPlayer.transform;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
