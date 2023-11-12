using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ServiceLocator.Utilities;
using ServiceLocator.Player;
using ServiceLocator.Events;
using ServiceLocator.Map;
using ServiceLocator.Wave;
using ServiceLocator.Sound;
using ServiceLocator.UI;

public class GameService : GenericMonoSingleton<GameService>
{
    public PlayerService PlayerService { get; private set; }
    public EventService EventService { get; private set; }
    public MapService MapService { get; private set; }
    public WaveService WaveService { get; private set; }
    public SoundService SoundService { get; private set; }

    [SerializeField] private UIService uiService;
    public UIService UIService { get { return uiService; } }


    [SerializeField] private PlayerScriptableObject playerScriptableObject;

    [SerializeField] private MapScriptableObject mapScriptableObject;

    [SerializeField] private WaveScriptableObject waveScriptableObject;

    [SerializeField] private SoundScriptableObject soundScriptableObject;
    [SerializeField] private AudioSource audioEffects;
    [SerializeField] private AudioSource backgroundMusic;

    protected override void Initialize()
    {
        PlayerService = new PlayerService(playerScriptableObject);
        EventService = new EventService();
        MapService = new MapService(mapScriptableObject);
        WaveService = new WaveService(waveScriptableObject);
        SoundService = new SoundService(soundScriptableObject, audioEffects, backgroundMusic);
    }

    private void Start()
    {
        PlayerService.Start();
        MapService.Start();
        WaveService.Start();
        SoundService.Start();
    }

    
    private void Update()
    {
        PlayerService.Update();
    }
}
