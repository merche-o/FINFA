using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseHero : BaseVolleyer{

	public BaseHero(string _name, ClassType _type, POSITION _pos) : base ( _name,  _type, _pos) {
		targetType = SkillTarget.TEAM;
	}

	override protected void OnMouseOver(){
		base.OnMouseOver ();
		if(Input.GetMouseButtonDown(0)){
			Debug.Log("click on Ally");
		}
	}
}
