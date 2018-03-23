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
	public bool isServer;
	public bool isActive;

	public string description;
	public ClassType type;
	public string className;
	public List<Stats> baseStats;
	public List<Stats> currentStats;
	public List<Alterations> currentAlterations;
	public List<Alterations> permAlterations;
	public List<Skills> moveList;
	//public GameObject gameObj;
	public SkillTarget targetType;

	public BaseVolleyer (string _name, ClassType _type, POSITION _pos, bool serv = false) {
		Vname = _name;
		type = _type;
		cur_pos = _pos;
		isServer = serv;
		moveList = new List<Skills>();

		setBasicSkill ();
	}
	virtual public void init(string _name, ClassType _type, POSITION _pos, bool serv = false) {
		Vname = _name;
		type = _type;
		cur_pos = _pos;
		moveList = new List<Skills>();
		isServer = serv;
		setBasicSkill ();

	}

	void setBasicSkill() {
		SkillFactory sFact = new SkillFactory ();
		moveList.Add (sFact.createPassSkill());
		moveList.Add (sFact.createServiceSkill());
		moveList.Add (sFact.createShotSkill());
	}

	protected virtual void OnMouseOver(){

		this.displayStatsWindow ();
		if(Input.GetMouseButtonDown(0)){
			// Display hero information clicked on the hero panel
			BattleStateMachine bsm = GameObject.Find ("BattleManager").GetComponent<BattleStateMachine>();
			HandlePanels panel = GameObject.Find ("Canvas").GetComponent<HandlePanels>();
			panel.updateTargetPanel (this);

			if (isClickable(bsm)) {
				selectTarget (bsm);
			}

		}

	}

	void displayStatsWindow(){
		//Debug.Log("Should display volleyer information description");

		
	// put a UI window that display name, currentHP, currentMP and stats of the Volleyer
	}

	bool isClickable (BattleStateMachine bsm) {
		if (bsm.battleStates == BattleStateMachine.PerformAction.HUMAN && bsm.currentTurn.skill) {
		
			if ((bsm.currentTurn.skill.sTarget == SkillTargetType.FRIENDLY && this.targetType == bsm.currentTurn.attackerGameObject.targetType) || (bsm.currentTurn.skill.sTarget == SkillTargetType.ENEMYLY && bsm.currentTurn.attackerGameObject.targetType != this.targetType)) {
				foreach (POSITION pos in bsm.currentTurn.skill.posTarget) {
					if (pos == cur_pos)
						return true;
				}
			}
		}
		return false;
	}

	void selectTarget(BattleStateMachine bsm) {

		bsm.currentTurn.targetGameObject = this;
		bsm.currentTurn.targetName = this.Vname;
		bsm.currentTurn.targetType = this.type;
		Debug.Log("Should launch skill");
		//should change battlestate 
		bsm.battleStates = BattleStateMachine.PerformAction.TAKEACTION;


	}
}
