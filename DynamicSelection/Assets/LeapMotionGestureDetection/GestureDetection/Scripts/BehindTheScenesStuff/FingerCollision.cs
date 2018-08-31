﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerCollision : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        SelectableObject selectObj = other.gameObject.GetComponent<SelectableObject>();

        if (selectObj)
        {
            selectObj.StartActivation();
            DetectionManager.Get().ChangeCurrentObject(other.gameObject);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        SelectableObject selectObj = other.gameObject.GetComponent<SelectableObject>();

        if (selectObj)
        {
            selectObj.EndActivation();
        }
    }
}
