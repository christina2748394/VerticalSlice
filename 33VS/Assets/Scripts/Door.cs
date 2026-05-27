using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public string _doorSwitchToScene;
    public override void OnInteracted()
    {
        SceneManager.LoadScene(_doorSwitchToScene);
    }


}

