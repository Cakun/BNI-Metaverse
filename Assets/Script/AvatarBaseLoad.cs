using System.Collections.Generic;
using UnityEngine;

public class AvatarBaseLoad : MonoBehaviour
{
    [Header("Avatar")]
    public List<GameObject> fullBodyA;
    public List<GameObject> fullBodyD;

    public void FullBodyA()
    {
        for (int i = 0; i < fullBodyA.Count; i++)
        {
            fullBodyA[i].SetActive(true);
        }
    }

    public void FullBodyD()
    {
        for (int i = 0; i < fullBodyD.Count; i++)
        {
            fullBodyD[i].SetActive(false);
        }
    }
}
