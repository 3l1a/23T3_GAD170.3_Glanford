using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            SceneManager.LoadScene(0);
            
            Cursor.lockState = CursorLockMode.None;
                
        }

        //if this dosnt work all the time aaron said it was okay 
    }


}
