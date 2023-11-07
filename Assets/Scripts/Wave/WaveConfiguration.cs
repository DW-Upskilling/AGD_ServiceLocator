using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator.Wave
{
    [CreateAssetMenu(fileName = "WaveConfiguration", menuName = "ScriptableObjects/WaveConfiguration")]
    public class WaveConfiguration : ScriptableObject
    {
        public int MapID;
        public List<WaveData> WaveDatas;
    }
}