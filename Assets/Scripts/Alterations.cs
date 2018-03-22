using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Alteration_TYPE
{
	TEMP,
	PERM,
}

[System.Serializable]
public class Alterations {
	
	public string name;
	public string description;
	public Stats stats;
	public float value;
	public int duration;
}
