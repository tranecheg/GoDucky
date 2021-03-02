using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class ShowRewardedAds : MonoBehaviour, IUnityAdsListener
{
    private string gameId = "3996257";
    private string type = "rewardedVideo";
    private static int countLoses;

    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, true);
        if (countLoses % 3 == 0 && countLoses != 0)
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

    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            PlayerPrefs.SetInt("score", 100);
        }
        else if (showResult == ShowResult.Skipped)
        {
            PlayerPrefs.SetInt("score", 0);
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string surfacingId)
    {
       
    }

    public void OnUnityAdsDidError(string message)
    {
        
    }

    public void OnUnityAdsDidStart(string placementId)
    {
    }
}

