﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 1;
        }
        timer -= Time.deltaTime;
    }
}
