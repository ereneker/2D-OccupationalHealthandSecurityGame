using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public GameObject interactionButton;
    public GameObject Player;
    public Animator cameraAnim;
    public GameObject clockPanel;

    private bool isInsideTrigger = false;

    void Update()
    {
        if (isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player.transform.position = new Vector3(10.19f, -4.9f, 0.0f);
                cameraAnim.SetBool("camMove", true);
                StartCoroutine(ClockVisible());
            }
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            isInsideTrigger = true;
            interactionButton.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            isInsideTrigger = false;
            interactionButton.SetActive(false);
        }
    }
    public IEnumerator ClockVisible()
    {
        clockPanel.SetActive(false);
        yield return new WaitForSeconds(1f);
        clockPanel.SetActive(true);
    }

}
