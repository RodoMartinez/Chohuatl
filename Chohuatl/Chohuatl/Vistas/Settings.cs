using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chohuatl.Vistas
{
    public static class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string EstadoTutorial
        {
            get => AppSettings.GetValueOrDefault(nameof(EstadoTutorial), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(EstadoTutorial), value);
        }

        public static bool Estilo
        {
            get => AppSettings.GetValueOrDefault(nameof(Estilo), true);
            set => AppSettings.AddOrUpdateValue(nameof(Estilo), value);
        }
    }
}
