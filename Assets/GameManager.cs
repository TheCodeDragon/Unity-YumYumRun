using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject GO_VictoryPanel;
    public GameObject GO_FailurePanel;
    public GameObject GO_Player;

    private Rigidbody2D rb_Player;
	// Use this for initialization
	void Start () {
        //Get Rigidbody reference
        rb_Player = GO_Player.GetComponent<Rigidbody2D>();
        //Make sure the victory/failure panels are false:
        GO_FailurePanel.SetActive(false);
        GO_VictoryPanel.SetActive(false);
        //Spawn a player
        Reset();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Run this for victory condition
    public void Victory()
    {
        rb_Player.isKinematic = true;
        GO_VictoryPanel.SetActive(true);

    }
    //Run this for failure condition
    public void Failure()
    {
        rb_Player.isKinematic = true; 
        GO_FailurePanel.SetActive(true);
    }
    //Reset Game
    public void Reset()
    {
        GO_FailurePanel.SetActive(false);
        GO_VictoryPanel.SetActive(false);
        SpawnPlayer();
    }
    //Destroy the player
    void SpawnPlayer()
    {
        GO_Player.transform.position = new Vector2(0, 2);
        if(rb_Player.isKinematic == true)
        {
            rb_Player.isKinematic = false;
        }
    }
}
