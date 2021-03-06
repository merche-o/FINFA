﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public enum SKILL_TYPE {
	Pass,
	Shot,
	Counter,
	DropShot,
	Smash,
	Serve
}

public enum SkillTarget {
	TEAM1,
	TEAM2
}

public enum SkillTargetType {
	FRIENDLY,
	ENEMYLY
}

[Serializable]
public class Skills : Button {


	public SKILL_TYPE type;
	public string skillName;
	public string desc;
	public SkillTargetType sTarget;
	public List<POSITION> posTarget;
	public List<Alterations> alterations;
	//add image

	public Skills() {
		posTarget = new List<POSITION>();
		alterations = new List<Alterations>();
	}

	public override void OnPointerClick (PointerEventData eventData)
	{
		base.OnPointerClick (eventData);

		BattleStateMachine bsm = GameObject.Find ("BattleManager").GetComponent<BattleStateMachine>();
		if (bsm.battleStates == BattleStateMachine.PerformAction.HUMAN && bsm.currentTurn.attackerGameObject != null)
		{
			bsm.currentTurn.skill = this;
		}
	}

	public override void OnPointerEnter (PointerEventData eventData)
	{
		base.OnPointerEnter (eventData);
		Debug.Log("Should display " + skillName +" description");

	}


}
