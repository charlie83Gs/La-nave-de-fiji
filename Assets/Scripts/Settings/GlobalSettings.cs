using UnityEngine;

public class GlobalSettings : Singleton<GlobalSettings>
{
    public AreaSettings settings;

    private void Start()
    {
        settings = new AreaSettings();
    }

    public void update(AreaSettings setting)
    {
        Debug.Log(setting);
    }
}
