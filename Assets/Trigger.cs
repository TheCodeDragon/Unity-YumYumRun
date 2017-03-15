using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
    public bool bl_isVictory = false;
    public GameObject GO_Player;
    public GameManager GO_GameManager;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (bl_isVictory)
            {
                GO_GameManager.Victory();
            }
            if (!bl_isVictory)
            {
                GO_GameManager.Failure();
            }
        }

    }
}
