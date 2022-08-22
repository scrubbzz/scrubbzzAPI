using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using scrubbzzPathFindingAPI;
public class Grid : MonoBehaviour
{
    LineDrawer lineDrawer = new LineDrawer();
    AStar aStar = new AStar();


    // Start is called before the first frame update
    void Start()
    {
        lineDrawer.cellCountX = 10;
        lineDrawer.cellCountZ = 10;
        lineDrawer.CreateNodeGrid(lineDrawer.cellCountX, lineDrawer.cellCountZ);
        lineDrawer.OnDrawGizmos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
