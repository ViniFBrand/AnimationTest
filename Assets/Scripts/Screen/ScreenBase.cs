using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;
using UnityEngine.UI;

namespace Screens
{
    public enum ScreenType
    {
        Menu,
        Settings,
        Shop
    }

    public class ScreenBase : MonoBehaviour
    {
        public ScreenType ScreenType;

        public List<Transform> listOfObjects;
        public List<Typper> listOfSentences;

        public Image uiBackground;
        public bool startHidden = false;
        public bool firstType = false;

        [Header("Animation")]
        public float animationDuration = .3f;
        public float delayBetweenObjects = .05f;

        private void Start()
        {
            if (startHidden)
            {
                HideObjects();
            }
        }

        
        [Button]
        public virtual void Show()
        {
            ShowObjects();
            Debug.Log("Show");
        }

        [Button]
        public virtual void Hide()
        {
            Debug.Log("Hide");
            HideObjects();
        }

        private void HideObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
            Invoke(nameof(StartUntype), 0);
            //uiBackground.enabled = false;
        }

        private void ShowObjects()
        {

            for (int i = 0; i< listOfObjects.Count; i++)
            {
                var obj = listOfObjects[i];

                obj.gameObject.SetActive(true);
                obj.DOScale(0, animationDuration).From().SetDelay(i * delayBetweenObjects);
            }

            Invoke(nameof(StartType), delayBetweenObjects * listOfObjects.Count);
            //uiBackground.enabled = true;
        }

        private void StartType()
        {
            for (int i = 0; i < listOfSentences.Count; i++)
            {
                firstType = true;
                listOfSentences[i].StartType();
            }
        }

        private void StartUntype()
        {
            if (firstType)
            {
                for (int i = 0; i < listOfSentences.Count; i++)
                {
                    listOfSentences[i].StartUntype();
                }
            }
        }

        private void ForceShowObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(true));
            //uiBackground.enabled = true;
        }
    }
}
