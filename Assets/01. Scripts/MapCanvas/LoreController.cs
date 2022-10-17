using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MapCanvas
{
    public class LoreController : MonoBehaviour
    {
        [SerializeField]
        private Text regionName = null;

        public void SetRegionName(string text)
        {
            regionName.text = text;
        }
    }
}