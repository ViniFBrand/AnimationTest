using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Screens
{

    public class ScreenHelper : MonoBehaviour
    {
        public ScreenType screenType;
        public Typper typper;


        public void OnClick()
        {
            ScreenManager.Instance.ShowByType(screenType);
            /* TRYING TO STOP TYPPING AS CLICK BUTTON
            var sentence = typper.textMesh.text = "";
            typper.StartCoroutine(sentence);
            */
        }
    }

}