﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uGUIHandleCanvas : MonoBehaviour {

	private CanvasScaler scaler;
	
	void Start () {
		scaler = GetComponent<CanvasScaler>();

		scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
	}
}
