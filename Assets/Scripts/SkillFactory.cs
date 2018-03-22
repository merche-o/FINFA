using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory {

	public Skills createPassSkill() {

		Skills pass = new Skills ();

		pass.skillName = "Pass";
		pass.type = SKILL_TYPE.Pass;
		pass.sTarget = SkillTarget.TEAM;
		addAllPosition (pass.posTarget);
		//Have to come up whith the alteration of the pass
		return pass;
	}

	public Skills createShotSkill() {

		Skills skill = new Skills ();

		skill.skillName = "Shot";
		skill.type = SKILL_TYPE.Shot;
		skill.sTarget = SkillTarget.ENEMY;
		addAllPosition (skill.posTarget);
		//Have to come up whith the alteration of the pass
		return skill;
	}

	public Skills createServiceSkill() {

		Skills skill = new Skills ();

		skill.skillName = "Serve";
		skill.type = SKILL_TYPE.Serve;
		skill.sTarget = SkillTarget.ENEMY;
		addAllPosition (skill.posTarget);
		//Have to come up whith the alteration of the pass
		return skill;
	}


	void addAllPosition (List<POSITION> list) {

		list.Add(POSITION.BACK_L);
		list.Add(POSITION.BACK_M);
		list.Add(POSITION.BACK_R);
		list.Add(POSITION.FRONT_L);
		list.Add(POSITION.FRONT_M);
		list.Add(POSITION.BACK_R);

	}


}
