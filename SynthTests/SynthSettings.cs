using NAudio.Wave.SampleProviders;
using System;
using System.Data;
using System.Linq;

namespace SynthTests
{
    /// <summary>
    /// -- Describe here to what is this class used for. (What is it's purpose) --
    /// </summary>
    public class SynthSettings
    {
        public static SignalGeneratorType[] SignalTypes { get; set; } = Enum.GetValues(typeof(SignalGeneratorType)).Cast<SignalGeneratorType>().ToArray();
        public SignalGeneratorType SignalType { get; set; } = SignalGeneratorType.Sin;

        #region Singleton          

        private static SynthSettings instance;

        public static SynthSettings Instance => instance ??= new SynthSettings();

        private SynthSettings()
        { }

        #endregion Singleton
    }
}
