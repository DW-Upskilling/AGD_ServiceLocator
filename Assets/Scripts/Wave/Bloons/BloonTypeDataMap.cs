using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator.Wave.Bloon
{
    [CreateAssetMenu(fileName = "BloonTypePrefabMap", menuName = "ScriptableObjects/BloonTypePrefabMap")]
    public class BloonTypeDataMap : ScriptableObject
    {
        public BloonView BloonPrefab;
        public List<BloonScriptableObject> BloonScriptableObjects;
    }
}