using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GetStart : MonoBehaviour {

    public Vector3 tempVector = Vector3.zero;
    // Use this for initialization
    public RectTransform imagePos;
    private bool isIn = false;
	void Start () {
        DOTween.To(()=>tempVector,x=> tempVector =x,new Vector3(10,10,10),20f);
        // imagePos.DOMove(new Vector3(0, 0, 0), 10f);//修改的是世界坐标
        Tween tweener = imagePos.DOLocalMove(new Vector3(0, 0, 0), 10f);//默认动画播放完成后会被销毁
                                                                        //Tweener对象保存这个动画的信息，每次掉用do类型方法都会创建一个tweener，这个对像由dotween管理
        tweener.SetAutoKill(false);
        tweener.Pause();
    }
	
	// Update is called once per frame
	void Update () {
        //transform.position = tempVector;
	}

    public void OnClick(){
        if (isIn == false)
        {
            //Doplay  掉用一次。  多次掉用使用DoPlayForward
            imagePos.DOPlayForward();
            isIn = true;
           
        }
        else
        {
            isIn = false;
            imagePos.DOPlayBackwards();
        }

    }
}
