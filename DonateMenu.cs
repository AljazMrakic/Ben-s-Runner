using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonateMenu : MonoBehaviour
{
    public void OpenPayPal()
    {
        Application.OpenURL("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2PTTADMQEFYXW&source=url");
    }

    public void OpenPatreon()
    {
        Application.OpenURL("https://www.patreon.com/preycat9");
    }
}
