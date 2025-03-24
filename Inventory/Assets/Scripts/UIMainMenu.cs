using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public GameObject userInfo;
    public Button statusBtn;
    public Button inventoryBtn;
    public TextMeshPro gold;


    // Start is called before the first frame update
    void Start()
    {
        userInfo= GetComponent<GameObject>();
        statusBtn= GetComponent<Button>();
        inventoryBtn= GetComponent<Button>();
        gold= GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMainMenu()
    {

    }

    public void OpenStatus()
    {

    }

    public void OpenInventory()
    {

    }
}
