using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Utilities;
using ServiceLocator.Player;

public class GameService : GenericMonoSingleton<GameService>
{
    public PlayerService PlayerService { get; private set; }

    [SerializeField] public PlayerScriptableObject playerScriptableObject;

    protected override void Initialize()
    {
        PlayerService = new PlayerService(playerScriptableObject);
    }

    void Start()
    {
        PlayerService.Start();
    }

    
    void Update()
    {
        PlayerService.Update();
    }
}
