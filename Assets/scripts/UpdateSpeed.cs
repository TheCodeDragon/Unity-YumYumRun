using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSpeed : MonoBehaviour {
    public RandomSpeedChange scpt_SpeedChanger;
    public Text tx_GUIText;
    public string st_PrefixText;
	// Use this for initialization
	void Start () {
        scpt_SpeedChanger = GameObject.Find("TreadmillPhysics").GetComponent<RandomSpeedChange>();
	}
	
	// Update is called once per frame
	void Update () {
        tx_GUIText.text = st_PrefixText + scpt_SpeedChanger.fl_currentSpeed;
	}
}
