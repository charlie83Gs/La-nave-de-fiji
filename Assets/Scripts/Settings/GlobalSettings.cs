using UnityEngine;

public class GlobalSettings
{
    public AreaSettings settings;
    private static GlobalSettings instance;
    private static bool m_ShuttingDown = false;

    protected GlobalSettings() {}

    private void Start()
    {
        settings = new AreaSettings();
    }

    public void update(AreaSettings setting)
    {
        Debug.Log(setting);
    }

    public static GlobalSettings Instance
    {
        get
        {
            if (m_ShuttingDown)
            {
                return null;
            }

            if (instance == null)
            {
                Debug.Log("Instance created");
                instance = new GlobalSettings();
            }
            else
            {
                Debug.Log("Instance was already created");
            }

            return instance;
        }
    }

    private void OnApplicationQuit()
    {
        m_ShuttingDown = true;
    }

    public AreaSettings GetSettings()
    {
        if (settings == null)
        {
            Debug.Log("Area settings created");
            settings = new AreaSettings();
        }

        return settings;
    }

    private void OnDestroy()
    {
        m_ShuttingDown = true;
    }
}
