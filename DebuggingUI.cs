using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebuggingUI : MonoBehaviour
{

  /*

  ** DO NOT REMOVE **
  Debugging Code via Thirdplace Studios
    Developed by Damien Davis-Neff (damien@thirdplacestudios.ga)



  */

  /*

  To Use:
    -- Apply Script To Object (Either Empty Or Canvas, I Prefer Canvas To Keep Things In One Spot)
    -- Set Player Object (Optional, Required For Player Debugging)
    -- Set Player Text (Optional, Required To View Player Debugging)
    -- Set FPS Text (Optional, Required To View FPS)
    -- Set Frametime Text (Optional, Required To View Frametimes)
    -- Configure Options
    -- DO NOT REMOVE CREDITS / LICENSE
    -- Remove This Comment (Optional)

  */

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

    Debug.Log("Player Debugging Active");
  }

}
