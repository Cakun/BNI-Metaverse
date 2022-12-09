using UnityEngine.SceneManagement;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    public string exitButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(exitButton);
            PlayerPrefs.DeleteAll();
            Debug.Log("Exit");
        }
    }
}
