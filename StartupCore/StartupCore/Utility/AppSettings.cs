using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using StartupCore.Models;
using StartupCore.Extensions;


namespace StartupCore.Utility
{
    public static class AppSettings
    {
        private static ISettings Settings => CrossSettings.Current;

        public static User User
        {
            get => Settings.GetValueOrDefault(nameof(User), default(User));

            set => Settings.AddOrUpdateValue(nameof(User), value);
        }
    }
}
