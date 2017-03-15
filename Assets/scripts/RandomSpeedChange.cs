using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpeedChange : MonoBehaviour {
    //Script changes between 4 speeds:
    /* Slow
     * Medium
     * Fast
     * ludicrous speed
     */
    private int[] in_speedSettings = new int[4] {5,10,20,30};
    public float fl_delayBetweenChanges;
    public float fl_currentSpeed; //this is exposed for the GUI
    private float fl_timer;
    private AreaEffector2D AE_Treadmill;
    // Use this for initialization
	void Start () {
        AE_Treadmill = GetComponent<AreaEffector2D>();
        fl_timer += fl_delayBetweenChanges;
	}
	
	// Update is called once per frame
	void Update () {
		if(fl_timer < Time.time)//If the time has elapsed
        {
            AE_Treadmill.forceMagnitude = in_speedSettings[Random.Range(0, in_speedSettings.Length)];//Change the speed
            fl_timer += fl_delayBetweenChanges;//And then add the delay onto the timer
            fl_currentSpeed = AE_Treadmill.forceMagnitude;//Updates the current speed;
        }
	}
}
