using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

	public void PlayGameButton() {
		UnityEngine.SceneManagement.SceneManager.LoadScene ("GamePlay");

	}
	public void QuitGameButton() {
		Application.Quit ();
	}
}
