using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using System;

public class MusicOnClick : MonoBehaviour {
	public void MusicOnClics()
	{
		GetComponent<AudioSource>().Play();
	}
}
