using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlaceBlocks : MonoBehaviour {

    public TextMeshProUGUI BlocksPlacedUI;
    //UI

    public Camera cam;

    public GameObject blocks;
    public Vector3 hitPos;

    public LayerMask mask;

    bool canPlace = true;

    public int CurrentBlockPlaced = 0;
    public int MaxBlockPlaced = 20;

    public float grid = 2.5f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            if(Physics.Raycast(ray , out hit))
            {
                hitPos.x = Mathf.Round(hit.point.x);
                hitPos.z = Mathf.Round(hit.point.z); 

                if (hitPos.y < 0.1 && hit.collider.gameObject.tag != "Troops" && hit.collider.gameObject.tag != "Obstacle" && CurrentBlockPlaced <   MaxBlockPlaced)
                {
                    Instantiate(blocks, hitPos, Quaternion.identity);
                    CurrentBlockPlaced++;
                    BlocksPlacedUI.text = CurrentBlockPlaced + " / " + MaxBlockPlaced + " blocks placed";
                }
            }
        }


	}

}
