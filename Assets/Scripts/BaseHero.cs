using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseHero : BaseVolleyer{

	public BaseHero(string _name, ClassType _type, POSITION _pos, bool serv = false) : base ( _name,  _type, _pos, serv) {
		targetType = SkillTarget.TEAM1;

	}

	override public void init(string _name, ClassType _type, POSITION _pos, bool serv = false) {
		base.init (_name, _type, _pos, serv);
		targetType = SkillTarget.TEAM1;

	}


	override protected void OnMouseOver(){
		base.OnMouseOver ();
		if(Input.GetMouseButtonDown(0)){
			Debug.Log("click on Ally");
		}
	}
}
