﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ElementoInteractivo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public bool pulsado;

	public void OnPointerDown (PointerEventData eventData) {
		pulsado = true;
	}

	public void OnPointerUp (PointerEventData eventData) {
		pulsado = false;
	}
}
