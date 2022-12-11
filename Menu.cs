
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour

{

    public int level;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("Level0" + level.ToString());
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
