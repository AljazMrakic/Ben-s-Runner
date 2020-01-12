using System.Collections;
using UnityEngine;
using UnityEngine.Monetization;

public class AdsManager : MonoBehaviour
{
    private string game_id = "3237226";

    private string video_ad = "video";
    private string reward_video = "rewardedVideo";

    public void Start()
    {
        Monetization.Initialize(game_id, false);

        if (Monetization.IsReady(video_ad))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(video_ad) as ShowAdPlacementContent;

            if (ad != null)
                ad.Show();
        }
    }

    public void ShowAd()
    {
        StartCoroutine(WaitForAd());
    }

    IEnumerator WaitForAd()
    {
        while (!Monetization.IsReady(reward_video))
        {
            yield return null;
        }

        ShowAdPlacementContent ad = null;
        ad = Monetization.GetPlacementContent(reward_video) as ShowAdPlacementContent;

        if (ad != null)
        {
            ad.Show(AdFinished);
        }
    }

    void AdFinished(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            // Reward the player
        }
    }
}
