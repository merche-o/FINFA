using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateMachine : MonoBehaviour {

	public enum PerformAction
	{
		WAIT,
		TAKEACTION,
		PERFORMACTION
	};

	public PerformAction battleStates;
	public List<HandleTurn> performList = new List<HandleTurn> ();

	public List<GameObject> HerosInBattle = new List<GameObject> ();
	public List<GameObject> EnemiesInBattle = new List<GameObject> ();

	public enum HeroGUI {
		ACTIVATE,
		INACTIVE,
		INPUT1,
		INPUT2,
		DONE
	}

	public HeroGUI heroInput;

	// Use this for initialization
	void Start () {

		battleStates = PerformAction.WAIT;
		EnemiesInBattle.AddRange (GameObject.FindGameObjectsWithTag ("Enemy"));
		HerosInBattle.AddRange (GameObject.FindGameObjectsWithTag ("Hero"));


	}
	
	// Update is called once per frame
	void Update () {

		switch (battleStates) {
		case (PerformAction.WAIT):
			if (performList.Count > 0) {
				battleStates = PerformAction.TAKEACTION;
			}
			break;
		case (PerformAction.TAKEACTION):
			GameObject perfomer = performList [0].attackerGameObject;
			if (performList [0].attackerType == "Enemy") {
				performList [0].attackerGameObject.GetComponent<EnemyStateMachine> ().target = performList [0].targetGameObject;
				performList [0].attackerGameObject.GetComponent<EnemyStateMachine> ().currentState = EnemyStateMachine.PerformAction.ACTION;
			} else if (performList [0].attackerType == "Hero") {
				
			}
			battleStates = PerformAction.PERFORMACTION;
			break;
		case (PerformAction.PERFORMACTION):
			battleStates = PerformAction.WAIT;
			break;
		}
		
	}

	public void CollectAction(HandleTurn input) {
		performList.Add (input);
	}
}
