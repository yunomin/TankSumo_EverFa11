using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    private bool enterHeld;
    public Object enemyPrefab;
    public GameObject SpawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        enterHeld = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("return") && !enterHeld)
        {
            enterHeld = true;
            Instantiate(enemyPrefab, SpawnLocation.transform.position, Quaternion.identity);
        }
        else
        {
            enterHeld = false;
        }
    }
}
