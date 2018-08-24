using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MoveCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //transform.DOMoveX(6, 1);
        //默认从指定位置运行到当前位置
        //transform.DOMoveX(6, 1).From();
        //这种情况 是从目标位置+6的X位置移动过来~
        transform.DOMoveX(6, 1).From(true);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
