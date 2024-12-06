using System.Collections.Generic;
using UnityEngine;

namespace Lec17
{
    public class Book : MonoBehaviour
    {

        // public Transform coverBookPivot;
        public float maxBookOpeningAngle = 180f;
        public float bookClosingAngle = 0f;
        public float openBookSpeed = 10f;

        public bool isUseRotateFunction;

        public List<Transform> pages;

        public int pageIndex = 0;

        private GameObject scaleContentGameObjectSelected;
        private GameObject scalePositionContentGameObjectSelected;

        void Start()
        {
        }

        void Update()
        {
            if (isUseRotateFunction)
                OpenBookWithRotationFunc();
            else
                OpenBookWithRotation();
        }


        private void OpenBookWithRotation()
        {
            float scrollVal = Input.GetAxis("Mouse ScrollWheel");
            if (scrollVal != 0)
            {
                Vector3 rotateVec = pages[pageIndex].localEulerAngles;
                rotateVec.z = Mathf.Clamp(rotateVec.z + scrollVal * openBookSpeed, bookClosingAngle, maxBookOpeningAngle);

                pages[pageIndex].rotation = Quaternion.Euler(rotateVec);

                PopupBox();

                NextOrBackToPage();
            }
        }

        private void OpenBookWithRotationFunc()
        {
            float scrollVal = Input.GetAxis("Mouse ScrollWheel");
            if (scrollVal != 0)
            {
                float zAxisVal = pages[pageIndex].localEulerAngles.z + scrollVal;
                if (zAxisVal > 0 && zAxisVal < 180)
                {
                    pages[pageIndex].Rotate(Vector3.forward * scrollVal * openBookSpeed);
                }

                PopupBox();

                NextOrBackToPage();

            }
        }

        private void PopupBox()
        {
            if (pageIndex + 1 < pages.Count)
            {
                if (pageIndex > 0)
                {
                    PopDownBoxForCurrentPage();
                }

                PopUpBoxForNextPage();
            }
        }

        private void PopDownBoxForCurrentPage()
        {
            GameObject scaleContentGameObjectPrevious = getChildrenContentOnTag(pages[pageIndex].gameObject, "Scale");
            if (scaleContentGameObjectPrevious != null)
            {
                Vector3 contentGameObjectScale = scaleContentGameObjectPrevious.transform.localScale;
                contentGameObjectScale.y = pages[pageIndex].localEulerAngles.z / maxBookOpeningAngle;
                scaleContentGameObjectPrevious.transform.localScale = contentGameObjectScale;
            }

            GameObject scalePositionContentGameObjectPrevious = getChildrenContentOnTag(pages[pageIndex].gameObject, "ScalePosition");
            if (scalePositionContentGameObjectPrevious != null)
            {
                Vector3 contentGameObjectScale = scalePositionContentGameObjectPrevious.transform.localScale;
                contentGameObjectScale.y = pages[pageIndex].localEulerAngles.z / maxBookOpeningAngle;

                Vector3 contentGameObjectPosition = scalePositionContentGameObjectPrevious.transform.localPosition;
                contentGameObjectPosition.x = (1 - (pages[pageIndex].localEulerAngles.z / maxBookOpeningAngle)) * -1;

                scalePositionContentGameObjectPrevious.transform.localScale = contentGameObjectScale;
                scalePositionContentGameObjectPrevious.transform.localPosition = contentGameObjectPosition;
            }
        }

        private void PopUpBoxForNextPage()
        {
            if (scaleContentGameObjectSelected == null)
            {
                scaleContentGameObjectSelected = getChildrenContentOnTag(pages[pageIndex + 1].gameObject, "Scale");
            }

            if (scaleContentGameObjectSelected != null)
            {
                Vector3 contentGameObjectScale = scaleContentGameObjectSelected.transform.localScale;
                contentGameObjectScale.y = 1 - (pages[pageIndex].localEulerAngles.z / maxBookOpeningAngle);
                scaleContentGameObjectSelected.transform.localScale = contentGameObjectScale;
            }


            if (scalePositionContentGameObjectSelected == null)
            {
                scalePositionContentGameObjectSelected = getChildrenContentOnTag(pages[pageIndex + 1].gameObject, "ScalePosition");
            }

            if (scalePositionContentGameObjectSelected != null)
            {
                Vector3 contentGameObjectScale = scalePositionContentGameObjectSelected.transform.localScale;
                contentGameObjectScale.y = 1 - (pages[pageIndex].localEulerAngles.z / maxBookOpeningAngle);

                Vector3 contentGameObjectPosition = scalePositionContentGameObjectSelected.transform.localPosition;
                contentGameObjectPosition.x = pages[pageIndex].localEulerAngles.z * -1 / maxBookOpeningAngle;

                scalePositionContentGameObjectSelected.transform.localScale = contentGameObjectScale;
                scalePositionContentGameObjectSelected.transform.localPosition = contentGameObjectPosition;
            }
        }

        private GameObject getChildrenContentOnTag(GameObject gameObj, string tagName)
        {

            foreach (Transform child in gameObj.transform.GetChild(0))
            {
                if (child.CompareTag(tagName))
                {
                    return child.gameObject;
                }
            }

            return null;
        }

        private void NextOrBackToPage()
        {
            if (pages[pageIndex].localEulerAngles.z >= 180)
            {
                pageIndex = Mathf.Clamp(pageIndex - 1, 0, pages.Count - 2);
                scaleContentGameObjectSelected = null;
                scalePositionContentGameObjectSelected = null;

            }
            else if (pages[pageIndex].localEulerAngles.z <= 0)
            {
                pageIndex = Mathf.Clamp(pageIndex + 1, 0, pages.Count - 2);
                scaleContentGameObjectSelected = null;
                scalePositionContentGameObjectSelected = null;
            }

        }

    }

}