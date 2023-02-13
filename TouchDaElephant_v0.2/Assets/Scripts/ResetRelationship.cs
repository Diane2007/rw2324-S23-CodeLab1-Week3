using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetRelationship : MonoBehaviour
{
    //player click on the button and set the reset bool to true
    //then the rest of work will happen in Game Manager
    public void ResetData()
    {
        ResetMaster.Instance.resetDataBool = true;
        SceneManager.LoadScene("OpenScene");
    }
}
