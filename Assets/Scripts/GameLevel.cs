﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class GameLevel : ScriptableObject {

	public int numberOfBalls = 10;
	public Material skybox;
	public GameObject levelBlocks;
	public Canvas scoreCanvas;

	public string sceneAssetName = "LevelScene";

}