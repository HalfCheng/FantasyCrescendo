﻿using HouraiTeahouse.Loadables;
using HouraiTeahouse.Tasks;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = HouraiTeahouse.Loadables.Scene;

namespace HouraiTeahouse.FantasyCrescendo {

public class SceneLoader : MonoBehaviour {

  public bool LoadOnAwake = true;
  public LoadSceneMode Mode;
  [SerializeField, Scene] string[] _scenes;

  /// <summary>
  /// Awake is called when the script instance is being loaded.
  /// </summary>
  void Awake() {
    if (LoadOnAwake) {
      LoadScenes();
    }
  }

  public void LoadScenes() {
    Task.All(_scenes.Select(Scene.Get).Select(s => s.LoadAsync(Mode)))
      .Then(() => Debug.Log("Scenes loaded!"));
  }

}

}