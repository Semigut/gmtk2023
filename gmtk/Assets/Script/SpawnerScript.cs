using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerScript : MonoBehaviour
{

    public float maxTime = 1;   
    private float timer = 0.5f;
    public GameObject spawn1, spawn2, spawn3, spawn4, spawn5, spawn6;
    public float height;
    int randomspawn;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newspaner = Instantiate(spawn1);
        newspaner.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer > maxTime )
        {
           randomspawn = UnityEngine.Random.Range (1,6);

            switch (randomspawn)
            {
                case 1:
                    GameObject newspaner = Instantiate(spawn1);
                    newspaner.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
                    Destroy(newspaner, 15);
                    timer = 0;
                    break;
                case 2:
                    GameObject newspaner2 = Instantiate(spawn2);
                    newspaner2.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
                    Destroy(newspaner2, 15);
                    timer = 0;
                    break;
                case 3:
                    GameObject newspaner3 = Instantiate(spawn3);
                    newspaner3.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
                    Destroy(newspaner3, 15);
                    timer = 0;
                    break;
                case 4:
                    GameObject newspaner4 = Instantiate(spawn4);
                    newspaner4.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
                    Destroy(newspaner4, 15);
                    timer = 0;
                    break;
                case 5:
                    GameObject newspaner5 = Instantiate(spawn5);
                    newspaner5.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
                    Destroy(newspaner5, 15);
                    timer = 0;
                    break;
                case 6:
                    GameObject newspaner6 = Instantiate(spawn5);
                    newspaner6.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
                    Destroy(newspaner6, 15);
                    timer = 0;
                    break;
            }
            
        }

        timer += Time.deltaTime;
    }
}
