using UnityEngine;

public class GlobalSettings : Singleton<GlobalSettings>
{
    public AreaSettings settings;
    
    protected GlobalSettings() { }
    private void Start()
    {
        settings = new AreaSettings();
    }

    public void update(AreaSettings setting)
    {
        Debug.Log(setting);
    }
}
