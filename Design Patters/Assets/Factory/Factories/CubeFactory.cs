using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFactory : Factory
{
    [SerializeField] private Cube cubePrefab;
    public override IShape CreateShape(Vector3 pos)
    {
        GameObject cubeInstance = Instantiate(cubePrefab.gameObject, pos, Quaternion.identity);
        Cube newCube = cubeInstance.GetComponent<Cube>();

        newCube.Initialize();
        newCube.SayYourName();

        return newCube;
    }


}
