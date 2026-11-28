
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject PauseMenu;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("FrontEnd");
    }

    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

}
