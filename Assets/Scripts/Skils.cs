using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SKILL_TYPE {
	Pass,
	Shot,
	Counter,
	DropShot,
	Smash,
	Serve
}

[System.Serializable]
public class Skills {
	

	public SKILL_TYPE type;
	public string name;
	public string desc;
	public List<Alterations> alterations;
	//add image


}
