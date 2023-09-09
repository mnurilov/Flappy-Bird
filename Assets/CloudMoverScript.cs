using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoverScript : MonoBehaviour
{
    public float deadZone;

    public CloudSpawnerScript cloudSpawner;

    // Start is called before the first frame update
    void Start()
    {
        cloudSpawner = GameObject.FindGameObjectWithTag("CloudSpawner").GetComponent<CloudSpawnerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * cloudSpawner.moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Cloud Deleted");
            Destroy(gameObject);
        }
    }
}
