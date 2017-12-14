using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;

    private GameObject player;
    private GameObject agent;
    private int spawnDuration;

    public Text scoreText;
    public int score;
    public GameObject parentPlayer;
    public GameObject parentAgent;
    public Vector3 endPoint;
    public Vector3 spawnPoint;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start ()
    {
        spawnPoint = GameObject.Find("Spawn Point").transform.position;
        endPoint = GameObject.Find("End Point").transform.position;

        parentAgent = GameObject.Find("3D");
        parentPlayer = GameObject.Find("2D");

        agent = Resources.Load("Prefabs/Agent") as GameObject;
        player = Resources.Load("Prefabs/Player") as GameObject;

        StartCoroutine(SpawnPlayer());
    }

    private void Update()
    {
        scoreText.text = "Score = "+score;
    }

    IEnumerator SpawnPlayer()
    {
        spawnDuration = Random.Range(1, 20);
        Instantiate(agent, spawnPoint, Quaternion.identity).transform.parent = parentAgent.transform;
        Instantiate(player, spawnPoint, Quaternion.Euler(90, 0, 0)).transform.parent = parentPlayer.transform;
        yield return new WaitForSeconds(spawnDuration);
        StartCoroutine(SpawnPlayer());
    }
}
