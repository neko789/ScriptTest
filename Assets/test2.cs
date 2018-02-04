using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
    {
        private int mp = 53;
        public void Magic()
        {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        }
    }

public class test2 : MonoBehaviour {
	// Use this for initialization
	void Start () {
    Boss zako = new Boss();
		for (int i = 0; i <=12; i++)
    {
        zako.Magic();
    } 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
