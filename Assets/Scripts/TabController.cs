using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabController : MonoBehaviour
{
    public List<GameObject> tabWindows;

    public void OpenTabWindow(int tab)
    {
        for(int i = 0; i < tabWindows.Capacity; i++)
        {
            if(i != tab)
            {
                tabWindows[i].SetActive(false);
            }
            else
            {
                tabWindows[i].SetActive(true);
            }
        }
    }

    public void OpenBlueprintTabWindow(int tab)
    {
        for (int i = 0; i < tabWindows.Capacity; i++)
        {
            if (i != tab)
            {
                tabWindows[i].SetActive(false);
            }
            else if (i == tab && tabWindows[i].activeSelf)
            {
                tabWindows[i].SetActive(false);
            }
            else
            {
                tabWindows[i].SetActive(true);
            }
        }
    }
}
