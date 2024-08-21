public class SceneController
{
    private readonly PlayerFactory _playerFactory;
    private readonly IInputSystem _inputSystem;

    public SceneController(PlayerFactory playerFactory, IInputSystem inputSystem)
    {
        _playerFactory = playerFactory ?? throw new System.ArgumentNullException(nameof(playerFactory));
        _inputSystem = inputSystem ?? throw new System.ArgumentNullException(nameof(inputSystem));
    }

    public void Update()
    {
    }

    public void Enter(SceneConfig sceneConfig)
    {
        Player player = _playerFactory.Create(sceneConfig.PlayerSpawnPoint.position);
    }

    public void Exit()
    {

    }
}