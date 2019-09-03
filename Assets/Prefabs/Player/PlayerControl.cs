using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public GameObject pause;
    public float deathDelay = 5.0f;
    public GameObject death;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.gameObject.SetActive(!(pause.gameObject.activeSelf));
            Time.timeScale = (Time.timeScale - 1)* (Time.timeScale - 1);
            //Time.timeScale == 1 ? 0 : 1
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Unpause()
    {
        pause.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void DeathScreen()
    {
        StartCoroutine(DeathRun(deathDelay));
    }

    IEnumerator DeathRun(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        death.SetActive(true);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
