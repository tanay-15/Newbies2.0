using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
[CommandInfo("Start","starting flowchart","test")]
public class Firstscenedialogue : Command {

    public override void OnEnter()
    {
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Phase1");
    }
}
