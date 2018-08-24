using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MyPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Tweener twee = transform.DOMoveX(5,2f);
        twee.SetEase(Ease.InBack);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
