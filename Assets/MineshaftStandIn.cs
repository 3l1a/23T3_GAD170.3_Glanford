using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MineshaftStandIn : MonoBehaviour
{

    [SerializeField] private GameObject PlayerMovement;
    [SerializeField] private int SceneIndexToLoad;
    [SerializeField] private KeyCode KeyToPress;
    public bool isPlayerClose = false;

    private void Update()
    {

        if (Input.GetKeyDown(KeyToPress) && isPlayerClose == true)
        {
            Debug.Log("E");

            DoorAactivate();
        }
    }

    private void DoorAactivate()
    {
        SceneManager.LoadScene(SceneIndexToLoad);

    }

    private void OnTriggerEnter(Collider other)
    {
        isPlayerClose = true;
    }
    private void OnTriggerExit()
    {
        isPlayerClose = false;
    }
}
