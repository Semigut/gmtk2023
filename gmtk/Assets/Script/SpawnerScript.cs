using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0.5f;
    public GameObject spawn;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newspaner = Instantiate(spawn);
        newspaner.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer > maxTime )
        {

            GameObject newspaner = Instantiate(spawn);
            newspaner.transform.position = transform.position + new Vector3 ( 0, Random.Range(-height, height), 0 );
            Destroy(newspaner, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
