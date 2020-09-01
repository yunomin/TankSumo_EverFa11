using UnityEngine;

public class SwitchPanelMenu : MonoBehaviour
{
    public GameObject BackgroundImage;
    public GameObject BeigeColor;

  
    void Start()
    {
        BackgroundImage = GameObject.Find("BackgroundImage");
        BeigeColor = GameObject.Find("BeigeColor");
    }

    public void hideControl()
    {

        BackgroundImage.SetActive(true);
        BeigeColor.SetActive(true);
    }

    public void showControl()
    {
        BackgroundImage.SetActive(false);
        BeigeColor.SetActive(false);
    }
}
