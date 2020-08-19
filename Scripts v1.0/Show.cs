﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show : MonoBehaviour
{
    public bool show = false;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        ShowImage();
    }

    private void ShowImage()
    {
        if (show)
        {
            this.GetComponent<Image>().enabled = true;
        }
        else
        {
            this.GetComponent<Image>().enabled = false;
        }
    }
}
