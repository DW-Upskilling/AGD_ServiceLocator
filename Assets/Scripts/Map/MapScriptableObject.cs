using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator.Map
{
    [CreateAssetMenu(fileName = "MapScriptableObject", menuName = "ScriptableObjects/MapScriptableObject")]
    public class MapScriptableObject : ScriptableObject
    {
        public List<MapData> MapDatas;
        public GameObject TileOverlay;
        public Color DefaultTileColor;
        public Color SpawnableTileColor;
        public Color NonSpawnableTileColor;
    }

    [System.Serializable]
    public struct MapData
    {
        public int MapID;
        public Grid MapPrefab;
        public Vector3 SpawningPoint;
        public List<Vector3> WayPoints;
    }
}