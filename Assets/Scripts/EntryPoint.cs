using UnityEngine;
using Zenject;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private SceneConfig _sceneConfig;

    private SceneController _sceneController;

    private void Update() =>
        _sceneController?.Update();

    private void OnDestroy() =>
        _sceneController.Exit();

    [Inject]
    private void Construct(SceneController sceneController)
    {
        _sceneController = sceneController;
        _sceneController.Enter(_sceneConfig);
    }
}