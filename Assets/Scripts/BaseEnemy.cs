using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy : BaseVolleyer{



	public enum DIFFICULTY {
		COMMON,
		UNCOMMON,
		RARE,
		SUPERRARE
	}
	public DIFFICULTY diff;
}
