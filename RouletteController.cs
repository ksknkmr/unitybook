using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

    float rotSpeed = 0; //回転速度

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//マウス押下で回転速度設定
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed = 10;
        }

        // 回転速度分、ルーレットを回転させる
        transform.Rotate(0,  0, this.rotSpeed);

        // ルーレットを原則させる（減衰係数)
        this.rotSpeed *= 0.96f;
	}
}
