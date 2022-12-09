using UnityEngine;

public class ResetSave : MonoBehaviour
{
    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
    }
}
