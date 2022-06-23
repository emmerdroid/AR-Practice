using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlacement : MonoBehaviour
{
    public GameObject[] ObjectsToSpawn;
    public GameObject placementIndicator;
    private GameObject spawnedObject;
    private Pose placementPose;
    private bool placementPoseIsValid = false;
    private ARRaycastManager raycastManager;
    [SerializeField] private ObjectSelection obj;
    

    // Start is called before the first frame update
    void Start()
    {
        raycastManager = FindObjectOfType<ARRaycastManager>();
        obj = new ObjectSelection();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (spawnedObject == null && placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //new function called for placing objects
            PlaceObject();
        }
     
        UpdatePlacementPose();
        UpdatePlacementIndicator();

    }
    void UpdatePlacementIndicator()
    {
        if (spawnedObject == null && placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        raycastManager.Raycast(screenCenter, hits, TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;
        }
    }
    void PlaceObject()
    {
        if(obj.currentObj == ObjectSelection.Objects.Cube) { spawnedObject = Instantiate(ObjectsToSpawn[0], placementPose.position, placementPose.rotation); }

        if(obj.currentObj == ObjectSelection.Objects.Capsule) { spawnedObject = Instantiate(ObjectsToSpawn[1], placementPose.position, placementPose.rotation); }
        
    }

    //void RemoveObject()
    //{
    //    Destroy(spawnedObject);
    //}
}