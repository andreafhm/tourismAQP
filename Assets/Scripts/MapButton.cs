using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapButton : MonoBehaviour
{
	public int levelIndex;

	void OnMouseDown()
	{
		//load level 
		SceneManager.LoadScene("Game");

		Debug.Log(levelIndex);
	}
}
