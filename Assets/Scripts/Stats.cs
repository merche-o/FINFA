using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Stats_TYPE
{
	SPEED,
// = "Speed",
	AGI,
// = "Agility",
	DEF,
// = "Defense",
	PWR,
// = "Power",
	AIM,
// = "Aim",
	LUCK,
// = "Luck",
	SMRT,
// = "Smart",
	ST,
// = "Stamina",
	TEAM,
//= "Team spirit",
	FAIR,
// = "Fairplay"
}


[System.Serializable]
public class Stats
{



	public Stats_TYPE type;
	public string name;
	public string description;

	//this is not the best place to but this variable
	public float value;

	//add image


}