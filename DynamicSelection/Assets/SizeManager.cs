﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeManager : MonoBehaviour {

    public enum ManipulatedObjectSize
    {
        Small,
        Medium,
        Large
    }

    GameObject m_object;
    GameObject originalObject;
    ManipulatedObjectSize currentSizeState = ManipulatedObjectSize.Medium;

    //  bool isOtherObject = false;

  


    void Update()
    {
        //If the manipulated object is initializing...
        //save this object to originalObject
        if (m_object == null)
        {
            m_object = DetectionManager.Get().GetCurrentGameObject();
            originalObject = m_object;
        }

        //If the manipulated object has changed 
        //update this object to originalobject
        if (m_object != null && (m_object != originalObject))
        {
            originalObject = m_object;
        }


        //originalSize = m_object.transform.localScale;
    }



    public void ChangetoSmallSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Small)
        {
            m_object.transform.localScale = originalObject.transform.localScale * 0.5f;
            currentSizeState = ManipulatedObjectSize.Small;
        }

        Debug.Log("The object has been changed to Small alread");
    }

    public void ChangetoMediumSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Medium)
        {
            m_object.transform.localScale = originalObject.transform.localScale * 1.2f;
            currentSizeState = ManipulatedObjectSize.Medium;
        }

        Debug.Log("The object has been changed to Medium alread");
    }

    public void ChangetoLargeSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Large)
        {
            m_object.transform.localScale = originalObject.transform.localScale * 1.5f;
            currentSizeState = ManipulatedObjectSize.Large;
        }

        Debug.Log("The object has been changed to Large alread");
    }
}
