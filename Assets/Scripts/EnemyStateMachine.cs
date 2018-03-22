using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//IA Behavior (state machine)
// Should make a special file that contains the IA action logic (targetting, skill selecting, etc...)

public class EnemyStateMachine : BaseEnemy {

	private BattleStateMachine BSM;
	public enum PerformAction {
		PROCESSING,
		CHOOSEACTION,
		WAITING,
		ACTION,
		DEAD
	}

	public PerformAction currentState;
	private float currentCD = 0f;
	private float maxCD = 2f;

	public float animSpeed = 5f;

	private Vector3 startPosition;
	private bool actionStarted = false;
	public GameObject target;

	// Use this for initialization
	void Start () {
		currentState = PerformAction.PROCESSING;
		BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine>();
		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case (PerformAction.PROCESSING):
			fillProgressBar ();
			break;
		case (PerformAction.CHOOSEACTION):
			ChooseAction ();
			currentState = PerformAction.WAITING;
			break;
		case (PerformAction.WAITING):
			// do idle animation
			break;
		case (PerformAction.ACTION):
			StartCoroutine (TimeForAction());
			break;
		case (PerformAction.DEAD):
			break;
		}
	}

	void fillProgressBar() {
		if (currentCD >= maxCD) {
			currentState = PerformAction.CHOOSEACTION;
		}
		currentCD = currentCD + Time.deltaTime;
	}

	void  ChooseAction () {
		HandleTurn myAttack = new HandleTurn ();
		myAttack.attackerName = this.Vname;
		//myAttack.attackerType = "Enemy";
		myAttack.attackerGameObject = this;
		//Add IA about choosing target
		myAttack.targetGameObject = BSM.HerosInBattle [Random.Range (0, BSM.HerosInBattle.Count)];
		BSM.CollectAction (myAttack);
	}
	private IEnumerator TimeForAction  () {
	
		if (actionStarted) {
			yield break;
		}
		actionStarted = true;

		//animate near the target
		Vector3 targetPos = new Vector3(target.transform.position.x + 1.5f,target.transform.position.y,target.transform.position.z);
		while (moveTowardEnemy(targetPos)) {
			yield return null;
		}

		//wait
		yield return new WaitForSeconds(0.5f);

		//do damage 

		//animate back to start position
		//Vector3 targetPos = new Vector3(startPosition.transform.position.x ,startPosition.transform.position.y,startPosition.transform.position.z);
		while (moveTowardEnemy(startPosition)) {
			yield return null;
		}
		BSM.performList.RemoveAt (0);
		actionStarted = false;
		//reset enemy state
		currentCD = 0f;
		currentState = PerformAction.PROCESSING;

	}

	private bool moveTowardEnemy(Vector3 target) {
		return target != (transform.position = Vector3.MoveTowards (transform.position, target, animSpeed * Time.deltaTime));
	}
}
