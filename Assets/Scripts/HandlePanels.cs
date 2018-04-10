using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandlePanels : MonoBehaviour  {

	public BaseVolleyer attackerVolleyer;
	public BaseVolleyer targetVolleyer;
	public GameObject SkillPrefab;


	public Text currentHeroName; 
	public Text currentEnemyName;
	public List<GameObject> UISkill;
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
		int i = 0;

		while (i < UISkill.Count) {

			Destroy(UISkill[i]);
			++i;
		}
		UISkill.Clear ();

		attackerVolleyer = hero;
		currentHeroName.text = hero.Vname;
		i = 0;
		while (i < hero.moveList.Count) {

			UISkill.Add (instiateSkill (hero.moveList [i], i));
			++i;
		}
	//	hero.moveList
	}
	public GameObject instiateSkill(Skills skill, int skillPos) {
		//modify transform depending of the skillPos
		GameObject SkillPanel = GameObject.Find("SkillPanel");
		GameObject SkillClone = Instantiate (SkillPrefab, SkillPanel.transform);
		SkillClone.transform.Translate (SkillClone.transform.localScale.x *100  * skillPos, 0, 0);
		Skills skillp  = SkillClone.GetComponent<Skills> ();
		skillp.skillName = skill.skillName;
		skillp.GetComponentInChildren<Text> ().text = skill.skillName;
		skillp.type = skill.type;
		skillp.sTarget = skill.sTarget;
		skillp.posTarget = skill.posTarget;
		return SkillClone;
	}
}
