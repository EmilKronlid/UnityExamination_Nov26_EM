using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeHandler : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(
            sceneName,
            LoadSceneMode.Single
        );
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}