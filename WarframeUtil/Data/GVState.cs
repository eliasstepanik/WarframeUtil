namespace WarframeUtil.Data;

public class GVState
{
    public bool IsDarkMode { get; set; } = false;
    public event Action OnChange;

    public void SetDarkMode(bool isDarkMode)
    {
        IsDarkMode = isDarkMode;
        NotifyStateChanged();
    }
    
    
    private void NotifyStateChanged()
    {
        OnChange?.Invoke();
    }
}