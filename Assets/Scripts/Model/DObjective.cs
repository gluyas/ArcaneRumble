﻿using Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DObjective : MonoBehaviour {
    public GameObject CurrentObjective;
    private Hex objectiveHex;
    private Renderer[] orenderer;
    Animator anim;

    public void setHex (Hex hex)
    {
        objectiveHex = hex;
    }

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start () {
        CurrentObjective = this.gameObject;
        orenderer = CurrentObjective.GetComponentsInChildren<Renderer>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if(objectiveHex.Objective.controllingPlayer != null)
        {
            orenderer[9].material.color = objectiveHex.Objective.controllingPlayer.Color;
        }
        //orenderer.material.color = objectiveHex.Owner.Color;
        

    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("IsOccupied", true);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("IsOccupied", false);
    }
}
