using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory : MonoBehaviour {

	public Skills createPassSkill() {


		Skills pass = new Skills ();

		pass.skillName = "Pass";
		pass.type = SKILL_TYPE.Pass;
		pass.sTarget = SkillTargetType.FRIENDLY;
		addAllPosition (pass);
		//Have to come up whith the alteration of the pass
		return pass;
	}

	public Skills createShotSkill() {

		Skills skill = new Skills ();

		skill.skillName = "Shot";
		skill.type = SKILL_TYPE.Shot;
		skill.sTarget = SkillTargetType.ENEMYLY;
		addAllPosition (skill);
		//Have to come up whith the alteration of the pass
		return skill;
	}

	public Skills createServiceSkill() {

		Skills skill = new Skills ();

		skill.skillName = "Serve";
		skill.type = SKILL_TYPE.Serve;
		skill.sTarget = SkillTargetType.ENEMYLY;
		addAllPosition (skill);
		//Have to come up whith the alteration of the pass
		return skill;
	}




	void addAllPosition (Skills list) {

		list.posTarget.Add(POSITION.BACK_L);
		list.posTarget.Add(POSITION.BACK_M);
		list.posTarget.Add(POSITION.BACK_R);
		list.posTarget.Add(POSITION.FRONT_L);
		list.posTarget.Add(POSITION.FRONT_M);
		list.posTarget.Add(POSITION.BACK_R);

	}


}
