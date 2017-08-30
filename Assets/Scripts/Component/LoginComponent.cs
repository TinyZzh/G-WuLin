using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Game;
using Assets.Scripts.Game.Plugin;
using UnityEngine;
using UnityEngine.UI;

public class LoginComponent : MonoBehaviour
{


    private Text _txtOpenId;


	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {
        this._txtOpenId = transform.Find("IptOpenId").GetComponent<Text>();
    }

    public void OnLogin()
    {
        if (_txtOpenId.text.Length <= 0)
        {
            
        }
        var plugin = Mafia.Instance.GetPlugin<MafiaPlugin>();
        if (plugin != null)
        {
            plugin.OnLogin(_txtOpenId.text);
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
