using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
	public string LevelToLoad = "";

	void OnTriggerEnter(Collider collision)                     // used for things like bullets, which are triggers.  
	{
		Application.LoadLevel(LevelToLoad);
	}
}