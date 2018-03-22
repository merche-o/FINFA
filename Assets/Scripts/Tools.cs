using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools {

	public string getTypeName (Stats_TYPE type)
	{
		switch (type) {
		case (Stats_TYPE.SPEED):
			return "Speed";
		case (Stats_TYPE.AGI):
			return "Agility";
		case (Stats_TYPE.PWR):
			return "Power";
		case (Stats_TYPE.AIM):
			return "Aim";
		case (Stats_TYPE.LUCK):
			return "Luck";
		case (Stats_TYPE.SMRT):
			return "Smart";
		case (Stats_TYPE.ST):
			return "Stamina";
		case (Stats_TYPE.TEAM):
			return "Team spirit";
		case (Stats_TYPE.FAIR):
			return "Fairplay";

		}
		return "UKNOWN";
	}

	public string getSkillName (SKILL_TYPE type)
	{
		switch (type) {
		case (SKILL_TYPE.Counter):
			return "Counter";
		case (SKILL_TYPE.DropShot):
			return "Dropshot";
		case (SKILL_TYPE.Pass):
			return "Pass";
		case (SKILL_TYPE.Serve):
			return "Serve";
		case (SKILL_TYPE.Shot):
			return "Shoot";
		case (SKILL_TYPE.Smash):
			return "Smash";
		}
		return "UKNOWN";
	}

	public string getCLassName (ClassType type)
	{
		switch (type) {
		case (ClassType.ATK):
			return "Attacker";
		case (ClassType.DEF):
			return "Defender";
		case (ClassType.PASS):
			return "Passer";
		case (ClassType.REC):
			return "Receptionner";
		case (ClassType.SNK):
			return "Sneaky";
		case (ClassType.SMH):
			return "Smasher";
		case (ClassType.BLK):
			return "Blocker";
		}
		return "UKNOWN";
	}
}
