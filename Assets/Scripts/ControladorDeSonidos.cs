﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeSonidos : MonoBehaviour
{
    public GameObject sonidoFondo;
    public GameObject sonidoClick;
    public GameObject sonidoNext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonSonSelec()
    {
        Instantiate(sonidoClick);
    }
    public void BotonFondo()
    {
        Instantiate(sonidoFondo);
    }
    public void BotonNext()
    {
        Instantiate(sonidoNext);
    }
}
