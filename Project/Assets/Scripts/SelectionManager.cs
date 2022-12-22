using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string treeTag = "Tree";
    [SerializeField] private GameObject chopText;
    [SerializeField] private float chopDamage = 1f;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Transform selection = hit.transform;
            if (selection.CompareTag(treeTag))
            {
                if (hit.distance < 2f)
                {
                    chopText.SetActive(true);
                    if (Input.GetMouseButtonDown(0))
                    {
                        selection.GetComponent<TreeManager>().ChopTree(chopDamage);
                    }
                }
            }
            else
            {
                chopText.SetActive(false);
            }
        }
    }
}