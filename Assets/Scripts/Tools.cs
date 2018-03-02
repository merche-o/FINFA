using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools {

	public string getTypeName (Stats_TYPE type)
	{
		switch (type) {
		case (Stats_TYPE.SPEED):
			return "Speed";
			break;
		case (Stats_TYPE.AGI):
			return "Agility";
			break;
		case (Stats_TYPE.PWR):
			return "Power";
			break;
		case (Stats_TYPE.AIM):
			return "Aim";
			break;
		case (Stats_TYPE.LUCK):
			return "Luck";
			break;
		case (Stats_TYPE.SMRT):
			return "Smart";
			break;
		case (Stats_TYPE.ST):
			return "Stamina";
			break;
		case (Stats_TYPE.TEAM):
			return "Team spirit";
			break;
		case (Stats_TYPE.FAIR):
			return "Fairplay";
			break;

		}
		return "";
	}

	public string getSkillName (SKILL_TYPE type)
	{
		switch (type) {
		case (SKILL_TYPE.Counter):
			return "Counter";
			break;
		case (SKILL_TYPE.DropShot):
			return "Dropshot";
			break;
		case (SKILL_TYPE.Pass):
			return "Pass";
			break;
		case (SKILL_TYPE.Serve):
			return "Serve";
			break;
		case (SKILL_TYPE.Shot):
			return "Shoot";
			break;
		case (SKILL_TYPE.Smash):
			return "Smash";
			break;
		}
		return "";
	}

	public string getCLassName (ClassType type)
	{
		switch (type) {
		case (ClassType.ATK):
			return "Attacker";
			break;
		case (ClassType.DEF):
			return "Defender";
			break;
		case (ClassType.PASS):
			return "Passer";
			break;
		case (ClassType.REC):
			return "Receptionner";
			break;
		case (ClassType.SNK):
			return "Sneaky";
			break;
		case (ClassType.SMH):
			return "Smasher";
			break;
		case (ClassType.BLK):
			return "Blocker";
			break;
		}
		return "";
	}
}
