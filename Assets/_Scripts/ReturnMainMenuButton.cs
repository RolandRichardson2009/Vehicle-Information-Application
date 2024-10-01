using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMainMenuButton : MonoBehaviour
{
    // Link to the Main Camera's Transform
    public Transform mainCam;

    // Float holding the Main Camera's new x position
    public float newCamX;

    // Float holding the Main Camera's new y position
    public float newCamY;

    // Link to Camera's audio source
    public AudioSource camAudio;

    // Link to audio clip for button
    public AudioClip buttonSound;

    // Custom method called by the button-click event
    public void ReturnToMainMenu()
    {
        // Set the Main Camera's x and y positions to the newCamX and the newCamY values
        // Leave the z position in the same spot
        mainCam.position = new Vector3(newCamX, newCamY, mainCam.position.z);

        // Use the camera's audio source to play button sound at 1/4 volume
        camAudio.PlayOneShot(buttonSound, 0.95f);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
