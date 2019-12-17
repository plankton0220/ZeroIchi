using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    bool canSceneChange = false; 
    // Start is called before the first frame update
    void Start()
    {
        canSceneChange = true;
    }

    // Update is called once per frame
    void Update()
    {
        // 仮置（マウスクリックでシーン繊維）
        if (Input.GetMouseButtonDown(0) && canSceneChange)
        {
            canSceneChange = false;
            FadeManager.FadeOut("GameScene");
        }
        /*
        if (GameController.VoiceMeeter >= 0.5 && canSceneChange)
        {
            canSceneChange = false;
            FadeManager.FadeOut("GameScene");
        }*/
    }
}
