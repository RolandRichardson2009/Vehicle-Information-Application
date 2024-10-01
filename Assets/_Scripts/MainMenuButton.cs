using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    // String holding a word to say
    public string buttonImage;

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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method called when object with collider clicked on
    public void OnMouseUp()
    {
        // Print to the cosole and concatenate the buttonImage string
        Debug.Log("You clicked the " + buttonImage + " image!");

        // Set the Main Camera's x and y positions to the newCamX and the newCamY values
        // Leave the z position in the same spot
        mainCam.position = new Vector3(newCamX, newCamY, mainCam.position.z);

        // Use the camera's audio source to play button sound at 1/4 volume
        camAudio.PlayOneShot(buttonSound, 0.95f);
    }
}
