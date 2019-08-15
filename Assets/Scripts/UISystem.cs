using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : MonoBehaviour
{
    UIScreen previousPage;
    UIScreen currentPage;


    // Start is called before the first frame update
    void Start()
    {
        //     var pages = GetComponentsInChildren<UIScreen>();
        UIScreen[] pages = GetComponentsInChildren<UIScreen>(true);
        pages[0].gameObject.SetActive(true);
        currentPage = pages[0];
        for( int i = 1; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }
         
    }

    public void SwitchPage(UIScreen page)
    {
        previousPage = currentPage;
        currentPage.gameObject.SetActive(false);
        page.gameObject.SetActive(true);
        currentPage = page;
    }
    public void SwitchBack(UIScreen page)
    {
        SwitchPage(page);
    }

}
