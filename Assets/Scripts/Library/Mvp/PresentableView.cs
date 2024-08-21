using UnityEngine;

public abstract class PresentableView<TPresenter> : View where TPresenter : Presenter
{
    protected TPresenter Presenter { get; private set; }

    private void OnEnable() =>
        Presenter?.Enable();

    private void Update()
    {
        Presenter?.Update(Time.deltaTime);
    }

    private void OnDisable() =>
        Presenter?.Disable();

    public void Construct(TPresenter presenter)
    {
        Disable();
        Presenter = presenter;
        Enable();
    }
}