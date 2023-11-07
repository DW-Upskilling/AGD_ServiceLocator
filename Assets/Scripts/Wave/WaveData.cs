using System.Collections.Generic;
using ServiceLocator.Wave.Bloon;

namespace ServiceLocator.Wave
{
    [System.Serializable]
    public struct WaveData
    {
        public int WaveID;
        public List<BloonType> ListOfBloons;
    }
}