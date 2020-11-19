using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public Animator transition;
  public float transitionTime = 1f;

    // Update is called once per frame
	public void PlayGame()
	{
	  StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
	}
	IEnumerator LoadLevel(int levelindex)
	{
			//play animation
			transition.SetTrigger("Start");
			//wait
			yield return new WaitForSeconds(transitionTime);
			//play scene
			SceneManager.LoadScene(levelindex);
	}
}
