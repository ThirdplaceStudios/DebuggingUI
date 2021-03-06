using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebuggingUI : MonoBehaviour
{

  // the gameobject this script is attatched too, set in Start() function
  GameObject o_This;

  [Header("Debugging Objects")]
  [Tooltip("The Player")]
  // the playable character, set by developer via inspector
  public GameObject o_Player;

  [Header("Frame Debugging")]
  [Tooltip("FPS Text Object")]
  // fps text to be  updated, set by developer via inspector
  public Text t_FPS;

  [Tooltip("Frametime Text Object")]
  // frametime text to be updated, set by the developer via inspector
  public Text t_FrameTime;

  [Header("Player Debugging")]
  [Tooltip("Player Text Object")]
  // player text to be updated, set by the developer via inspector
  public Text t_Player;

  [Header("Options")]
  [Tooltip("Is FPS Enabled?")]
  public bool b_FPS = true;

  [Tooltip("Is Other Debugging Enabled?")]
  public bool b_Debugging = false;

  void Start() {
    o_This = this.gameObject;
  }

  void Update() {
    DebugFPS();
    DebugFrametime();
    DebugPlayer();
  }

  void DebugFPS() {
    if(t_FPS != null && b_FPS) { t_FPS.text = "FPS: " + Mathf.Round(1 / Time.deltaTime); } else { t_FPS.text = ""; }
  }

  void DebugFrametime() {
    if(!b_Debugging) {t_FrameTime.text = ""; return; }
    if(t_FrameTime != null) { t_FrameTime.text = "Frametime: " + (Time.deltaTime * 1000) + "ms"; }
  }

  void DebugPlayer() {
    if(t_Player == null) return;
    if(!b_Debugging) {t_Player.text = ""; return; }
    if(o_Player == null) return;

    // You will need to fill in player information based on your movement script
  }

}
