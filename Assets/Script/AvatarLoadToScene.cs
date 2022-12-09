using System.Collections.Generic;
using UnityEngine;

public class AvatarLoadToScene : MonoBehaviour
{
    [Header("Select Gender")]
    public GameObject Masculine;
    public GameObject Feminine;

    bool isGender;
    void Start()
    {
        isGender = PlayerPrefs.GetString("STEP1") == "MASCULINE";
        if(isGender)
        {
            Masculine.SetActive(true);
        }
        else
        {
            Feminine.SetActive(true);
        }
    }

}
