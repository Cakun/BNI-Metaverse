using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void NextSceneWButton(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
}
