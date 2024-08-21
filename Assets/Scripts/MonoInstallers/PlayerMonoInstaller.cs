using Zenject;
using UnityEngine;

public class PlayerMonoInstaller : MonoInstaller
{
    [SerializeField] private CharacterConfig _characterConfig;
    [SerializeField] private CharacterView _characterPrefab;

    public override void InstallBindings()
    {
        Container.Bind<CharacterConfig>().FromInstance(_characterConfig).AsSingle();
        Container.Bind<CharacterView>().FromInstance(_characterPrefab).AsSingle();
        Container.Bind<CharacterViewFactory>().AsSingle();
    }
}