﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketDescription : MonoBehaviour {

	public enum SocketType
	{
		Execution, Variable
	}
	public enum IOType
	{
		Input, Output
	}
	
	[SerializeField]
	private TextMesh SocketName;
	public Color SocketColour { get { return SocketSprite.color; } }
	[SerializeField]
	private SpriteRenderer SocketSprite;

	[SerializeField]
	private Sprite[] SocketTypes;
	public SocketType TypeSocket { get; private set; }
	public IOType SocketIOType { get; private set; }


	public void SetName(string name)
	{
		//Give spacing, on both sides
		SocketName.text = "   " + name + "   ";
	}

	public void SetNameColour(Color colour)
	{
		SocketName.color = colour;
	}

	public void SeNameFontSize(float size)
	{
		SocketName.characterSize = size * 0.02f;
	}

	public void SetSocketColour(Color colour)
	{
		SocketSprite.color = colour;
	}

	public void SetSocketType(SocketType type)
	{
		TypeSocket = type;
		SocketSprite.sprite = SocketTypes[(int)type];
	}

	public void SetIOType(IOType type)
	{
		SocketIOType = type;

		if(type == IOType.Input)
			SocketName.anchor = TextAnchor.MiddleLeft;
		else
			SocketName.anchor = TextAnchor.MiddleRight;
	}
}
