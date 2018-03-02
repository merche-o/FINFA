using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum  ClassType {
	DEF ,
	BLK,
	ATK ,
	PASS ,
	REC ,
	SMH ,
	SNK // should change name though
}

[System.Serializable]
public class BaseVolleyer {
	


	public string name;
	public float baseHP;
	public float currentHP;
	public float baseMP;
	public float currentMP;
	public POSITION cur_pos;

	public string description;
	public ClassType type;
	public string className;
	public List<Stats> baseStats;
	public List<Stats> currentStats;
	public List<Alterations> currentAlterations;
	public List<Alterations> permAlterations;
}
