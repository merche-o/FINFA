using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectEnemyButton {

	public GameObject EnemyPrefab;

	public void SelectEnemy() {

		GameObject.Find ("BattleManager").GetComponent<BattleStateMachine>();
	
	}


}
