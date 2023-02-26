using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingControl : MonoBehaviour
{
    //public GameObject factPrefab;
    //public GameObject factPrefab2;
    //public GameObject factPrefab3;
    public string fact1Tag;
    public string fact2Tag;
    public string fact3Tag;
    private float x_pos = 0;
    private float z_pos = 0;
    public int numFact = 0;
    public int maxFact = 16;

    // Update is called once per frame
    public void buildBuilding(Building building)
    {
        if (numFact < maxFact){
            Vector3 NewPosition = new Vector3(x_pos, 5, z_pos);

            Instantiate(building, NewPosition, Quaternion.identity);
            numFact++;

            if (x_pos == 40)
            {
                x_pos = 0;
                z_pos += 5;
            }
            else { x_pos += 5; }
        }
    
    
    }

    public void destroyBuilding(Building building)
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(building.tag);
        if (gos.Length != 0)
        {
            Destroy(gos[gos.Length - 1]);
            numFact--;
        }      
    }

 }

