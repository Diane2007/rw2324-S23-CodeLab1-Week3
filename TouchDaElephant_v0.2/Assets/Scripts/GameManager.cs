using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //relationship data directories and files
    const string DIR_DATA = "/Data/";
    const string FILE_ELE_LIKE = "elephantRelationship.txt";
    const string FILE_GIR_LIKE = "giraffeRelationship.txt";
    private string PATH_ELE_LIKE;
    private string PATH_GIR_LIKE;
    
    //connect with pause menu
    public GameObject resetButton;
    
    //relationship values
    private int eleLike = 0;    //relationship point with elephant
    private int girLike = 0;    //relationship point with giraffe
    public int EleLike
    {
        get { return eleLike; }     //get the value of eleLike
        set
        {
            eleLike = value;        //can set eleLike to a certain value
            
            //record elephant relationship as txt file in the data folder
            Directory.CreateDirectory(Application.dataPath + DIR_DATA);
            File.WriteAllText(PATH_ELE_LIKE, "" + eleLike);
        }
    }

    public int GirLike
    {
        get { return girLike; }
        set
        {
            girLike = value;

            Directory.CreateDirectory(Application.dataPath + DIR_DATA);
            File.WriteAllText(PATH_GIR_LIKE, "" + girLike);
        }
    }

    void Start()
    {
        //make life easier, define the paths
        PATH_ELE_LIKE = Application.dataPath + DIR_DATA + FILE_ELE_LIKE;
        PATH_GIR_LIKE = Application.dataPath + DIR_DATA + FILE_GIR_LIKE;
        
        //if there is already files for ele & gir relationship, get the value
        if (File.Exists(PATH_ELE_LIKE))
        {
            EleLike = Int32.Parse(File.ReadAllText(PATH_ELE_LIKE));
        }
        if(File.Exists(PATH_GIR_LIKE))
        {
            GirLike = Int32.Parse(File.ReadAllText(PATH_GIR_LIKE));
        }
    }
    
    //text showing relationship with animals
    public TextMeshProUGUI eleText;
    public TextMeshProUGUI girText;

    void Update()
    {
        eleText.text = "Elephant Ellie likes you this much: " + EleLike;
        girText.text = "Giraffe Giovanni likes you this much: " + GirLike;

        //if the reset button is clicked and the reset bool is true
        if (ResetMaster.Instance.resetDataBool == true)
        {
            //delete the gir and ele txt files and reset relationship to 0
            File.Delete(PATH_ELE_LIKE);
            File.Delete(PATH_GIR_LIKE);

        }
    }
}
