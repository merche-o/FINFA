using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Player behavior

public class HeroStateMachine : BaseHero {

	//public BaseHero hero;

	public enum PerformAction {
		PROCESSING,
		ADDTOLIST,
		WAITING,
		SELECTING,
		ACTION,
		DEAD
	}

	public PerformAction currentState;
	private float currentCD = 0f;
	private float maxCD = 2f;
	public Image progressBar;

	// Use this for initialization
	void Start () {
		currentState = PerformAction.PROCESSING;
		
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case (PerformAction.PROCESSING):
			fillProgressBar ();
			break;
		case (PerformAction.ADDTOLIST):
			break;
		case (PerformAction.WAITING):
			break;
		case (PerformAction.SELECTING):
			break;
		case (PerformAction.ACTION):
			break;
		case (PerformAction.DEAD):
			break;
		}
	}

	void fillProgressBar() {
		if (currentCD >= maxCD) {
			currentState = PerformAction.ADDTOLIST;
		}
		currentCD = currentCD + Time.deltaTime;
		float calcCD = currentCD / maxCD;
	//	progressBar.transform.localScale = new Vector2(Mathf.Clamp(calcCD,0,1),progressBar.transform.transform.localScale.y);

	}


}
