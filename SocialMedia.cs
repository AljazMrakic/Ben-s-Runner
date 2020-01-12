using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialMedia : MonoBehaviour
{
    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/preycat9/");
    }

    public void OpenFacebook()
    {
        Application.OpenURL("https://www.facebook.com/preycat9/");
    }

    public void OpenYoutube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCu2nHwivlsNwCtgpZdQd7Rw/featured?view_as=subscriber");
    }
}
