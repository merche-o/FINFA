using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseHero : BaseVolleyer{

	 void OnMouseOver(){
		base.OnMouseOver ();
		if(Input.GetMouseButtonDown(0)){
			// Display hero information clicked on the hero panel
			Debug.Log("click on Hero");
			BattleStateMachine bsm = GameObject.Find ("BattleManager").GetComponent<BattleStateMachine>();
			if (bsm.battleStates == BattleStateMachine.PerformAction.HUMAN) {
				bsm.currentTurn.attackerGameObject = this.gameObj;
				bsm.currentTurn.attackerName = this.Vname;
				bsm.currentTurn.attackerType = this.type;
			}

		}
	}
}
