public class SceneController
{
    private readonly CharacterViewFactory _characterViewFactory;

    public SceneController(CharacterViewFactory characterViewFactory) => 
        _characterViewFactory = characterViewFactory ?? throw new System.ArgumentNullException(nameof(characterViewFactory));

    public void Update()
    {
    }

    public void Enter(SceneConfig sceneConfig)
    {
        CharacterView character = _characterViewFactory.Create(sceneConfig.PlayerSpawnPoint.position);
    }

    public void Exit()
    {

    }
}