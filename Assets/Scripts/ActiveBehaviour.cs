using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActiveBehaviour : MonoBehaviour
{
    public float rayLenght;
    public LayerMask layerMask;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLenght, layerMask))
            {
                FindObjectOfType<AudioManager>().Play("RemoveSound");
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
