using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum POSITION
{
	FRONT_L,
	FRONT_M,
	FRONT_R,
	BACK_L,
	BACK_M,
	BACK_R
}

public class BattleStateMachine : MonoBehaviour {

	public enum PerformAction
	{
		HUMAN,
		IA,
		WAIT,
		TAKEACTION,
		PERFORMACTION
	};

	public Transform HeroPrefab;
	public Transform EnemyPrefab;

	public HandleTurn currentTurn;
	public PerformAction battleStates;
	public List<HandleTurn> performList = new List<HandleTurn> ();

	public List<Transform> HerosInBattle = new List<Transform> ();
	public List<Transform> EnemiesInBattle = new List<Transform> ();

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

		battleStates = PerformAction.HUMAN;
		HerosInBattle = new List<Transform> ();
		EnemiesInBattle = new List<Transform> ();
	//	EnemiesInBattle.AddRange (GameObject.FindGameObjectsWithTag ("Enemy"));
	//	HerosInBattle.AddRange (GameObject.FindGameObjectsWithTag ("Hero"));
		generateTestHeroTeam();
		generateTestEnemyTeam ();
		currentTurn = new HandleTurn ();
		setServer ();
		setUIAttacker ();


	}

	void generateTestHeroTeam() {
		
		Transform HeroClone= (Transform)Instantiate (HeroPrefab, transform);
		HeroClone.GetComponent<HeroStateMachine> ().init ("h1", ClassType.ATK, POSITION.FRONT_L);
		HerosInBattle.Add(HeroClone);
		Transform HeroClone1 = Instantiate (HeroPrefab, transform);
		HeroClone1.GetComponent<HeroStateMachine> ().init ("h2", ClassType.ATK,POSITION.FRONT_M);
		HerosInBattle.Add(HeroClone1);
		Transform HeroClone2 = Instantiate (HeroPrefab, transform);
		HeroClone2.GetComponent<HeroStateMachine> ().init ("h3", ClassType.ATK,POSITION.FRONT_R);
		HerosInBattle.Add(HeroClone2);
		Transform HeroClone3= Instantiate (HeroPrefab, transform);
		HeroClone3.GetComponent<HeroStateMachine> ().init ("h4", ClassType.DEF,POSITION.BACK_L);
		HerosInBattle.Add(HeroClone3);
		Transform HeroClone4= Instantiate (HeroPrefab, transform);
		HeroClone4.GetComponent<HeroStateMachine> ().init ("h5", ClassType.DEF,POSITION.BACK_M);
		HerosInBattle.Add(HeroClone4);
		Transform HeroClone5= Instantiate (HeroPrefab, transform);
		HeroClone5.GetComponent<HeroStateMachine> ().init ("h6", ClassType.DEF,POSITION.BACK_R, true);
		HerosInBattle.Add(HeroClone5);
	
	}

	void generateTestEnemyTeam() {
		Transform EnemyClone= Instantiate (EnemyPrefab, transform);
		EnemyClone.GetComponent<EnemyStateMachine> ().init ("e1", ClassType.ATK, POSITION.FRONT_L);
		EnemiesInBattle.Add(EnemyClone);
		Transform EnemyClone1= Instantiate (EnemyPrefab, transform);
		EnemyClone1.GetComponent<EnemyStateMachine> ().init ("e2", ClassType.ATK,POSITION.FRONT_M);
		EnemiesInBattle.Add(EnemyClone1);
		Transform EnemyClone2 = Instantiate (EnemyPrefab, transform);
		EnemyClone.GetComponent<EnemyStateMachine> ().init ("e3", ClassType.ATK,POSITION.FRONT_R);
		EnemiesInBattle.Add(EnemyClone2);
		Transform EnemyClone3= Instantiate (EnemyPrefab, transform);
		EnemyClone.GetComponent<EnemyStateMachine> ().init ("e4", ClassType.DEF,POSITION.BACK_L);
		EnemiesInBattle.Add(EnemyClone3);
		Transform EnemyClone4 = Instantiate (EnemyPrefab, transform);
		EnemyClone4.GetComponent<EnemyStateMachine> ().init ("e5", ClassType.DEF,POSITION.BACK_M);
		EnemiesInBattle.Add(EnemyClone4);
		Transform EnemyClone5 = Instantiate (EnemyPrefab, transform);
		EnemyClone5.GetComponent<EnemyStateMachine> ().init ("e6", ClassType.DEF,POSITION.BACK_R);
		EnemiesInBattle.Add(EnemyClone5);
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
			launchSkill ();
			//BaseVolleyer perfomer = performList [0].attackerGameObject;

			/*if (performList [0].attackerType == "Enemy") {

				performList [0].attackerGameObject.GetComponent<EnemyStateMachine> ().target = performList [0].targetGameObject;
				performList [0].attackerGameObject.GetComponent<EnemyStateMachine> ().currentState = EnemyStateMachine.PerformAction.ACTION;
			} else if (performList [0].attackerType == "Hero") {
				// getFrom interface the target 
				//getFrom interface the skill
			}*/


			battleStates = PerformAction.PERFORMACTION;
			break;
		case (PerformAction.PERFORMACTION):
			finishTurn ();
			battleStates = PerformAction.HUMAN;
			break;
		}
		
	}

	public void CollectAction(HandleTurn input) {
		performList.Add (input);
	}

	public void launchSkill() {
		Debug.Log("Launch skill !");

	}

	public  void finishTurn() {
		currentTurn.attackerGameObject = currentTurn.targetGameObject;
		currentTurn.attackerName = currentTurn.targetName;
		setUIAttacker ();
		currentTurn.targetGameObject = null;
		currentTurn.skill = null;
		currentTurn.targetName = null;
	}

	void setUIAttacker() {
		/*currentTurn.attackerGameObject = (GameObject.FindGameObjectsWithTag ("Hero") [0]).GetComponent<HeroStateMachine>();
		currentTurn.attackerName = currentTurn.attackerGameObject.Vname;
		currentTurn.attackerType = currentTurn.attackerType;*/
		HandlePanels panel = GameObject.Find ("Canvas").GetComponent<HandlePanels>();
		panel.updateHeroPanel (currentTurn.attackerGameObject);

	}

	void setServer() {
		HandlePanels panel = GameObject.Find ("Canvas").GetComponent<HandlePanels>();

		foreach (Transform h in HerosInBattle) {
			if (h.GetComponent<HeroStateMachine> ().isServer == true) {
				Debug.Log("Server Found !");

				currentTurn.attackerGameObject = h.GetComponent<HeroStateMachine>();
				currentTurn.attackerName = currentTurn.attackerGameObject.Vname;
				currentTurn.attackerType = currentTurn.attackerGameObject.type;
				panel.updateHeroPanel (currentTurn.attackerGameObject);
				return;
			}
		}


		foreach (Transform h in EnemiesInBattle) {
			if (h.GetComponent<HeroStateMachine> ().isServer == true) {
				Debug.Log("Server Found !");

				currentTurn.attackerGameObject = h.GetComponent<HeroStateMachine>();
				currentTurn.attackerName = currentTurn.attackerGameObject.Vname;
				currentTurn.attackerType = currentTurn.attackerGameObject.type;
				panel.updateHeroPanel (currentTurn.attackerGameObject);
				return;
			}
		}
	}
}
