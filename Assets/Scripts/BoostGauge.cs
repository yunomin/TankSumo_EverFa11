using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostGauge : MonoBehaviour
{
    public GameObject thisGauge;
    private Vector3 scaleChange, positionChange;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(1, 1, 1);
        thisGauge.transform.localScale = Vector3.Scale(thisGauge.transform.localScale, scaleChange);
    }

    // Update is called once per frame
    void Update()
    {
        scaleChange = new Vector3(1, PlayerControls.boostCapacity / 100, 1);
        thisGauge.transform.localScale = scaleChange;

    }
}
