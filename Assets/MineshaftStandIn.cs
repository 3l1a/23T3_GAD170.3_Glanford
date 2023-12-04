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

    [SerializeField] private GameObject textLable;

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
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(SceneIndexToLoad);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerClose = true;

            textLable.SetActive(true);
        }
    }
    private void OnTriggerExit()
    {
        isPlayerClose = false;
        textLable.SetActive(false);
    }
}
