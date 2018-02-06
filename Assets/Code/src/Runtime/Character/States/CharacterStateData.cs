using System;
using UnityEngine;
using UnityEngine.Timeline;

namespace HouraiTeahouse.FantasyCrescendo {

public enum DirectionMode {
  PlayerControlled = 0,       // Normal, Players can turn by changing the controls
  Locked,                     // Locked, Direction remains fixed 
  AlwaysLeft,                 // Always set to left throughout the entire state.
  AlwaysRight,                // Always set to right throughout the entire state.
  InvertOnEnter,              // Inverts the direction the player is facing on entering the state.
  InvertOnExit                // Inverts the direction the player is facing on exiting the state.
}

public enum MovementType {
  Normal = 0,                // Normal Player Controlled Movement
  DirectionalInfluenceOnly,  //
  Locked,
  Forced
}

[Serializable]
public class CharacterStateData {
  [Tooltip("Corresponding timeline controller")]
  public TimelineAsset Timeline;
  [Tooltip("Corresponding animation for the state")]
  public AnimationClip AnimationClip;
  [Tooltip("Length of time the state lasts")]
  public float Length;
  [Tooltip("Minimum movement speeds. Interpolated based on input magnitude.")]
  public float MinMoveSpeed;
  [Tooltip("Maxiumum movement speeds. Interpolated based on input magnitude.")]
  public float MaxMoveSpeed;
  public float RotationOffset;
  public StateEntryPolicy EntryPolicy = StateEntryPolicy.Normal;
  public MovementType MovementType = MovementType.Normal;
  public DirectionMode DirectionMode = DirectionMode.PlayerControlled;
  public float KnockbackResistance;
}

}

