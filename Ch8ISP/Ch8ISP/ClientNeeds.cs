using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public interface IUserSettings
    {
        string Theme { get; set; }
    }

    public class UserSettingsConfig : IUserSettings
    {
        private const string ThemeSetting = "Theme";
        private readonly Configuration _config;
        private readonly IUserSettingsReader _reader;
        private readonly IUserSettingsWriter _writer;

        public UserSettingsConfig(
            Configuration config,
            IUserSettingsReader reader,
            IUserSettingsWriter writer)
        {
            _config = config;
            _reader = reader;
            _writer = writer;
        }

        public string Theme
        {
            get
            {
                return _reader.GetTheme();
            }
            set
            {
                _writer.SetTheme(value);
            }
        }
    }

    public class ReadingController
    {
        private readonly IUserSettingsReader _userSettings;
        public ReadingController(IUserSettingsReader userSettings)
        {
            _userSettings = userSettings;
        }
        public string GetTheme()
        {
            return _userSettings.GetTheme();
        }
    }
    public class WritingController
    {
        private readonly IUserSettingsWriter _userSettings;
        public WritingController(IUserSettingsWriter userSettings)
        {
            _userSettings = userSettings;
        }
        public void SetTheme(string theme)
        {
            if (_userSettings.GetTheme() != null)
            {
                _userSettings.SetTheme(theme);
            }
        }
    }

    public interface IUserSettingsReader
    {
        string GetTheme();
    }
    public interface IUserSettingsWriter : IUserSettingsReader
    {
        void SetTheme(string name);
    }
}
