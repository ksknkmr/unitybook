using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI使うときは忘れない

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;

	// Use this for initialization
	void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
	}
	
    public void DecreaseHp(){
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
