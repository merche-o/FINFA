using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skills {
	public enum SKILL_TYPE {
		Pass,
		Shot,
		Counter,
		DropShot,
		Smash,
		Serve
	}

	public SKILL_TYPE type;
	public string name;
	public string desc;
	public List<Alterations> alterations;
	//add image


}
