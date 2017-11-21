﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy {

	public enum  Type {
		GRASS,
		FIRE,
		WATER,
		ELECTRIC
	}

	public enum Rarity {
		COMMON,
		UNCOMMON,
		RARE,
		SUPERRARE
	}

	public Type enemyType;
	public Rarity rarity;

	public string name;
	public float baseHP;
	public float currentHP;
	public float baseMP;
	public float currentMP;

	public float baseATK;
	public float currentATK;
	public float baseDEF;
	public float currentDEF;


	public int stamina;
	public int intellect;
	public int dexterity;
	public int agility;

}
