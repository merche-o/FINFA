using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats {

	public enum Stats_TYPE {
		SPEED = "Speed",
		AGI = "Agility",
		DEF = "Defense",
		PWR = "Power",
		AIM = "Aim",
		LUCK = "Luck",
		SMRT = "Smart",
		ST = "Stamina",
		TEAM = "Team spirit",
		FAIR = "Fairplay"

	}

	public Stats_TYPE name;
	public string description;

	//this is not the best place to but this variable 
	public float value;

	//add image

}