using System;

namespace Global
{
    namespace Setting
    {
        class Setting : IDisposable
        {
            private string m_application;
            private string m_organization;
            Microsoft.Win32.RegistryKey m_registrykey;

            public string ApplicationName
            {
                get { return m_application; }
            }
            public string CompanyName
            {
                get { return m_organization; }
            }

            public Setting(string Organization, string Application)
            {
                m_organization = Organization;
                m_application = Application;
                m_registrykey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\" + m_organization + @"\" + m_application);
            }

            public void SetInt(string key, int value)
            {
                m_registrykey.SetValue(key, value);
            }

            public void SetString(string key, string value)
            {
                m_registrykey.SetValue(key, value);
            }

            public void SetBool(string key, bool value)
            {
                if (value)
                    m_registrykey.SetValue(key, 1);
                else
                    m_registrykey.SetValue(key, 0);
            }

            public int GetInt(string key, int defaultValue)
            {
                try
                {
                    return (int)m_registrykey.GetValue(key, defaultValue);
                }
                catch (InvalidCastException)
                {
                    return defaultValue;
                }
            }

            public string GetString(string key, string defaultValue)
            {
                try
                {
                    return (string)m_registrykey.GetValue(key, defaultValue);
                }
                catch (InvalidCastException)
                {
                    return defaultValue;
                }
            }

            public bool GetBool(string key, bool defaultValue)
            {
                try
                {
                    return (int)m_registrykey.GetValue(key, defaultValue) != 0;
                }
                catch(InvalidCastException)
                {
                    return defaultValue;
                }
            }

            public void Dispose()
            {
                m_registrykey.Close();
            }
        }
    }
}
