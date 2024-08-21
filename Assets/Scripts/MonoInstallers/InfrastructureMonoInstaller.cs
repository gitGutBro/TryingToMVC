using Zenject;
using UnityEngine;

public class InfrastructureMonoInstaller : MonoInstaller
{
    [SerializeField] private OldInputSystemConfig _inputSystemConfig;

    public override void InstallBindings()
    {
        Container.Bind<SceneController>().AsSingle();
        Container.Bind<IInputSystem>().To<OldInputSystem>().AsSingle();
        Container.Bind<OldInputSystemConfig>().FromInstance(_inputSystemConfig).AsSingle();
    }
}