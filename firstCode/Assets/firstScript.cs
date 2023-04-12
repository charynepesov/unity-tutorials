using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
	private int sayi;
    // Start is called before the first frame update
    void Start()
    {
    	Debug.Log("Merhaba Unity");
    	sayi = 0;        
    }

    // Update is called once per frame
    void Update()
    {
    	sayi++;
        Debug.Log(sayi);
    }
}
