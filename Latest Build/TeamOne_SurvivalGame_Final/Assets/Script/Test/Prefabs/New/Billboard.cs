﻿using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour 
{
	public Camera m_Camera;

	void Start()
	{
		m_Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
	}
	
	void Update()
	{
		transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.back,
		                 m_Camera.transform.rotation * Vector3.up);
	}
}
