using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image myImage;
    public Text cooldownText;

    public void ShowImage()
    {
        myImage.enabled = true;
        cooldownText.enabled = true;

    }

    public void HideImage()
    {
        myImage.enabled = false;
        cooldownText.enabled = false;

    }
}
