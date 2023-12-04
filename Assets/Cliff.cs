using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cliff : MonoBehaviour
{
    [SerializeField] private GameObject PlayerMovement;
    [SerializeField] private int SceneIndexToLoad;

    public bool isPlayerClose = false;

    // Update is called once per frame
    void Update()
    {
        if (isPlayerClose == true)
        {
            Die();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerClose = true;
        }
    }
    private void OnTriggerExit()
    {
        isPlayerClose = false;
    }

    private void Die()
    {
        Cursor.lockState = CursorLockMode.None;

        SceneManager.LoadScene(SceneIndexToLoad);

    }
}
