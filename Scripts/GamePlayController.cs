using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour {
	public static GamePlayController instance;
	void Awake() {
		MakeInstance ();
	}
	void MakeInstance() {
		if (instance == null)
			instance = this;
	}
		

	[SerializeField]private GameObject pausepanel, gameOverPanel;
	public void PauseGameButton() {
		pausepanel.SetActive (true);
		Time.timeScale = 0f;
	}
	public void ResumeGameButton() {
		pausepanel.SetActive (false);
		Time.timeScale = 1f;
	}
	public void RestartGameButton() {
		gameOverPanel.SetActive (false);
		UnityEngine.SceneManagement.SceneManager.LoadScene ("GamePlay");
	}
	public void OptionsButton() {
		UnityEngine.SceneManagement.SceneManager.LoadScene ("MainMenu");
	}
	public void PlaneDiedShowPanel() {
		gameOverPanel.SetActive (true);
	}
}
