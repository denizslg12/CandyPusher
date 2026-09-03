using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image myImage;
    public Text cooldownText;
    public Image myImage1;
    public Text cooldownText1;

    public void ShowImage()
    {
        myImage.enabled = true;
        cooldownText.enabled = true;
        myImage1.enabled = true;
        cooldownText1.enabled = true;

    }

    public void HideImage()
    {
        myImage.enabled = false;
        cooldownText.enabled = false;
        myImage1.enabled = false;
        cooldownText1.enabled = false;
    }
}
