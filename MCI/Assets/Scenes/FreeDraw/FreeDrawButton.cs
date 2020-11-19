using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FreeDrawButton : MonoBehaviour
{
  public Animator transition;
  public float transitionTime = 1f;

    // Update is called once per frame
    public void changeScene(string sceneName)
    {
StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
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
