using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SynthTests
{
    public class Note : INotifyPropertyChanged
    {
        private bool inPlay;

        public string Name { get; set; }
        public int Octave { get; set; }

        public string FullName => Name + Octave.ToString();

        public int Frequency { get; set; }

        public bool InPlay
        {
            get { return inPlay; }
            set
            {
                if (inPlay != value)
                {
                    inPlay = value;
                    if (value)
                    {
                        var t = new Thread(StartPlaying);
                        t.IsBackground = true;
                        t.Start();
                    }
                }
            }
        }

        private void StartPlaying()
        {
            try
            {
                var sine20Seconds = new SignalGenerator()
                {
                    Gain = 0.2,
                    Frequency = Frequency,
                    Type = SynthSettings.Instance.SignalType,
                };

                InPlay = true;

                using (var wo = new WaveOutEvent())
                {
                    wo.Init(sine20Seconds);
                    wo.Play();

                    while (InPlay)
                        Thread.Sleep(10);
                }
            }
            catch { }
        }

        #region Notify property changed
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
