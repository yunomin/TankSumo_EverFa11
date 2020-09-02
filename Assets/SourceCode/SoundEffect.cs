using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{

    public AudioSource BoostSound;
    public AudioSource ClickButton;
    // Start is called before the first frame update
    void Start()
    {
        BoostSound.playOnAwake = false;
        ClickButton.playOnAwake = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BoostSound.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            BoostSound.Stop();
        }
    }
    
    public void PlayClick()
    {
        ClickButton.Play();
    }
}
