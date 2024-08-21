using Zenject;

public class InfrastructureMonoInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<SceneController>().AsSingle();
    }
}