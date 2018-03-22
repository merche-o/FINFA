using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy : BaseVolleyer{



	public enum DIFFICULTY {
		COMMON,
		UNCOMMON,
		RARE,
		SUPERRARE
	}
	public DIFFICULTY diff;

	void OnMouseOver(){
		base.OnMouseOver ();
		if(Input.GetMouseButtonDown(0)){
			// Display Enemy information clicked on the enemy panel
			// put selectThe enemyclicked as a targer if it's player turn
			BattleStateMachine bsm = GameObject.Find ("BattleManager").GetComponent<BattleStateMachine>();
			if (bsm.battleStates == BattleStateMachine.PerformAction.HUMAN) {
				bsm.currentTurn.targetGameObject = this.gameObj;
				bsm.currentTurn.targetName = this.Vname;
				bsm.currentTurn.targetType = this.type;
			}
			Debug.Log("click on enemy");
		}
	}
}
