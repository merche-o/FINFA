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
public class BaseVolleyer : MonoBehaviour {
	


	public string Vname;
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
	public GameObject gameObj;
	protected virtual void OnMouseOver(){

		this.displayStatsWindow ();

	}

	void displayStatsWindow(){
		Debug.Log("Hover on Vollayer");

		
	// put a UI window that display name, currentHP, currentMP and stats of the Volleyer
	}
}
