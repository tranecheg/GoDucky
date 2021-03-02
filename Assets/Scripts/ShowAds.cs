using UnityEngine.Advertisements;
using UnityEngine;
using System.Collections;

public class ShowAds : MonoBehaviour
{
    private string gameId = "3996257";
    private string type = "Video";
    private static int countLoses;
    private void Start()
    {
       Advertisement.Initialize(gameId, true);
        if(countLoses % 1 ==0 && countLoses!=0)
        StartCoroutine(ShowAd());
        countLoses++;
    }
    IEnumerator ShowAd()
    {
        while (!Advertisement.IsReady(type))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Show(type);
        
    }

   
}
