﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MutationPanel : MonoBehaviour {
    bool first = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void optionSelected(ResearchButton selected)
    {
        foreach (Button b in GetComponentsInChildren<Button>())
        {
            b.GetComponent<Image>().color = b.colors.normalColor;
  
        }

        var col = selected.GetComponent<Image>().color;
        selected.GetComponent<Image>().color = selected.GetComponent<Button>().colors.highlightedColor;


    }

    public void AddMutation(Mutation mutation)
    {
        var buttons = GetComponentsInChildren<ResearchButton>();
        var aud = GetComponent<AudioSource>();
        if (aud != null && first == false)
        {
            aud.Play();
        }
        first = false;
        foreach (ResearchButton b in buttons)
        {
            if(b.associatedUpgrade == null)
            {
                b.setUpgrade(mutation);
                b.enabled = true;
                break;
            }
        }
    }
}
