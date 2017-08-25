using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanelComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Awake()
    {


        StartCoroutine(DoAction());

    }

    IEnumerator DoAction()
    {

        yield return 1;
    }

}
