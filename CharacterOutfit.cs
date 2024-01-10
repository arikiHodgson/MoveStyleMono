using System;
using System.Collections.Generic;
using UnityEngine;

namespace MoveStylerMono
{
	public class CharacterOutfit : MonoBehaviour
	{
		public string Name;
		public bool[] EnabledRenderers;
		public CharacterOutfitRenderer[] MaterialContainers;
	}
	public class CharacterOutfitRenderer : MonoBehaviour
	{
		public Material[] Materials;
		public bool[] UseShaderForMaterial;
	}
	public class CustomMovementStats : MonoBehaviour
	{
		public float runSpeed = 6.5f;
		public float walkSpeed = 1.8f;
		public float groundAcc = 16.5f;
		public float groundDecc = 24.9f;
		public float airAcc = 9.95F;
		public float airDecc = 2.0f;
		public float rotSpeedAtMaxSpeed = 8.0f;
		public float rotSpeedAtStill = 40f;
		public float rotSpeedInAir = 1.45f;
		public float grindSpeed = 11.5f;
		public float slideDeccHighSpeed = 2.5f;
		public float slideDeccLowSpeed = 3.8f;
	}



	
}