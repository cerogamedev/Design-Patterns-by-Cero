using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private LayerMask layerToClick;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Factory[] factories;

    private Factory factory;

    private void SpawnShapeOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            factory = factories[Random.Range(0, factories.Length)];

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, layerToClick) && factory!=null )
            {
                factory.CreateShape(hitInfo.point + offset);
            }
        }
    }
    private void Update()
    {
        SpawnShapeOnClick();
    }
}
