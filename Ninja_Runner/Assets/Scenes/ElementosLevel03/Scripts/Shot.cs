using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Shuriken;
    public Transform spawnPoint;

    public float shotForce = 1500;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Time.time > shotRateTime)
            {
                GameObject newShuriken;

                newShuriken = Instantiate(Shuriken, spawnPoint.position, spawnPoint.rotation);

                newShuriken.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newShuriken, 2);
            }
        }
    }
}
