using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy : BaseVolleyer{

	public BaseEnemy(string _name, ClassType _type, POSITION _pos) : base (_name, _type,  _pos) {
		targetType = SkillTarget.ENEMY;
	}

	public enum DIFFICULTY {
		COMMON,
		UNCOMMON,
		RARE,
		SUPERRARE
	}
	public DIFFICULTY diff;

	override protected void OnMouseOver(){
		base.OnMouseOver ();
		if(Input.GetMouseButtonDown(0)){
			Debug.Log("click on enemy");
		}
	}
}
