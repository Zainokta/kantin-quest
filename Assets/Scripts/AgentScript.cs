using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
public class AgentScript : MonoBehaviour {
    private PlayerScript player;
    private NavMeshAgent agent;
    private int randomindex;
    private int duration;

	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<PlayerScript>();
        StartCoroutine(Walk());
	}

    IEnumerator Walk()
    {
        duration = Random.Range(5, 20);
        randomindex = Random.Range(1, 13);
        agent.SetDestination(Objective.chair[randomindex]);
        yield return new WaitForSeconds(duration);
        player.Action();
        agent.SetDestination(GameManager.instance.endPoint);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
