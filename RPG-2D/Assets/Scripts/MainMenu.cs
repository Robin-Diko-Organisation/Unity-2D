using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string SceneAfterStart;
    [SerializeField] private GameObject Startbutton;
    [SerializeField] private string StartBurnAnimation;
    [SerializeField] private GameObject Endbutton;
    [SerializeField] private string EndBurnAnimation;

    public void PlayGame()
    {
        Startbutton.GetComponent<Animator>().Play(StartBurnAnimation);
        SceneManager.LoadScene(SceneAfterStart);
    }

    public void QuitGame()
    {
        Endbutton.GetComponent<Animator>().Play(EndBurnAnimation);
        Application.Quit();
    }
}
