using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour {
    [SerializeField]
    public Transform playerController;

    [SerializeField]
    public Transform entryPointRoom1;

    [SerializeField]
    public Transform entryPointRoom2;
    
    [SerializeField]
    public Transform entryPointRoom3;
    
    [SerializeField]
    public Transform entryPointRoom4;

   void Update()
    {
        // Check if the "1" key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerController.position = entryPointRoom1.position;
            // Add your code here that you want to execute when 1 is pressed
        }
        
        // Check if the "2" key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
             playerController.position = entryPointRoom2.position;
            // Add your code here that you want to execute when 2 is pressed
        }
        
        // Check if the "3" key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
             playerController.position = entryPointRoom3.position;
            // Add your code here that you want to execute when 3 is pressed
        }  
        
        // Check if the "4" key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
             playerController.position = entryPointRoom4.position;
            // Add your code here that you want to execute when 4 is pressed
        }
    }
}