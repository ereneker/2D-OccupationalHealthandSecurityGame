using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractionRight : MonoBehaviour
{
    public GameObject interactionButton;
    public GameObject Player;
    public Animator cameraAnim;
    public GameObject clockPanel;

    public bool isInsideTrigger = false;

    private void Update()
    {
        if (isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player.transform.position = new Vector3(6.14f, -4.5f, 0.0f);
                cameraAnim.SetBool("camMove", false);
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
