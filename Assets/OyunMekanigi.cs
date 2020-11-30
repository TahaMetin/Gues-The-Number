using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OyunMekanigi : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] int tahmin;
    [SerializeField] TextMeshProUGUI TahminMetni;

	// Use this for initialization
	void Start () {
        OyununBaslangici();
	}
	
    public void OyununBaslangici()
    {
        max = max + 1;
        SonrakiTahmin();

    }

    public void arttir()
    {
        min = tahmin;
        SonrakiTahmin();
    }

    public void azalt()
    {
        max = tahmin;
        SonrakiTahmin();
    }

    public void SonrakiTahmin()
    {
        //tahmin = (min + max) / 2;
        tahmin = Random.Range(min, max);
        TahminMetni.text = tahmin.ToString();
    }
	
}
