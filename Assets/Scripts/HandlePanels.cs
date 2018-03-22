using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandlePanels : MonoBehaviour  {

	public BaseVolleyer attackerVolleyer;
	public BaseVolleyer targetVolleyer;

	public Text currentHeroName; 
	public Text currentEnemyName;
	// Use this for initialization

	void Start () {
		//attackerVollyer should be set

	}

	void Update () {
	

	}

	void updateHeroPanel() {
	}

	public void updateTargetPanel(BaseVolleyer target) {
		targetVolleyer = target;
		currentEnemyName.text = targetVolleyer.Vname;

	
	}

	public void updateHeroPanel(BaseVolleyer hero) {
		attackerVolleyer = hero;
		currentHeroName.text = hero.Vname;

	}

}
