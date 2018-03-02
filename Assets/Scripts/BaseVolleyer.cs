using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BaseVolleyer {
	public enum  Type {
		DEF = "Defender",
		BLK = "Blocker",
		ATK = "Attacker",
		PASS = "Passer",
		REC = "Receptionner",
		SMH = "Smasher",
		SNK = "Snicky" // should change name though
	}



	public string name;
	public float baseHP;
	public float currentHP;
	public float baseMP;
	public float currentMP;
	public POSITION cur_pos;

	public string description;
	public Type type;
	public List<Stats> baseStats;
	public List<Stats> currentStats;
	public List<Alterations> currentAlterations;
	public List<Alterations> permAlterations;
}
