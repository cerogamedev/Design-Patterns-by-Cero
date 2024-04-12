using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFactory : Factory
{
    [SerializeField] private Sphere spherePrefab;
    public override IShape CreateShape(Vector3 pos)
    {
        GameObject sphereInstance = Instantiate(spherePrefab.gameObject, pos, Quaternion.identity);
        Sphere newSphere = sphereInstance.GetComponent<Sphere>();

        newSphere.Initialize();
        newSphere.SayYourName();

        return newSphere;
    }
}
