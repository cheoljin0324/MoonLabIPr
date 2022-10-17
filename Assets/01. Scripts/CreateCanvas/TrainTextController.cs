using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CreateCanvas
{
    public class TrainTextController : MonoBehaviour
    {
        [SerializeField]
        private Text tailText = null;

        [SerializeField]
        private Text middleText = null;

        [SerializeField]
        private Text headText = null;

        public void SetTailText(string text)
        {
            tailText.text = text;
        }

        public void SetMiddleText(string text)
        {
            middleText.text = text;
        }

        public void SetHeadText(string text)
        {
            headText.text = text;
        }
    }
}