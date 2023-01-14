using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //start function repeating every 4 seconds
        InvokeRepeating("InstantiateObjects", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5, Random.Range(-height, height), 0);
    }
    //Object that we will attach to the script for the following object
    [Header("Spikes object for controlling the game")]
    public GameObject spikes;
    //height of the sprite
    [Header("Default height")]
    public float height;
    void InstantiateObjects()
    {
        Instantiate(spikes, transform.position, transform.rotation);
    }

}
