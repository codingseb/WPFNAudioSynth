using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SynthTests
{
    /// <summary>
    /// -- Describe here to what is this class used for. (What is it's purpose) --
    /// </summary>
    public static class Notes
    {
        public static ObservableCollection<Note> BaseNotes { get; set; } = new ObservableCollection<Note>()
        {
            new Note(){ Name = "C", Frequency = 261, Octave = 4},
            new Note(){ Name = "D", Frequency = 293, Octave = 4},
            new Note(){ Name = "E", Frequency = 329, Octave = 4},
            new Note(){ Name = "F", Frequency = 349, Octave = 4},
            new Note(){ Name = "G", Frequency = 392, Octave = 4},
            new Note(){ Name = "A", Frequency = 440, Octave = 4},
            new Note(){ Name = "B", Frequency = 493, Octave = 4},
            new Note(){ Name = "C", Frequency = 523, Octave = 5},
        };

        public static ObservableCollection<Note> HalfNotes { get; set; } = new ObservableCollection<Note>()
        {
            new Note(){ Name = "C#", Frequency = 277, Octave = 4},
            new Note(){ Name = "D#", Frequency = 311, Octave = 4},
            new Note(){ Name = "-"},
            new Note(){ Name = "F#", Frequency = 369, Octave = 4},
            new Note(){ Name = "G#", Frequency = 415, Octave = 4},
            new Note(){ Name = "A#", Frequency = 466, Octave = 4},
        };

        public static Note GetNoteFromKeyboardKey(Key key)
        {
            return BaseNotes.GetNoteAtIndex(KeyboardLayout.Instance.WhiteKeys.IndexOf(key)) ?? HalfNotes.GetNoteAtIndex(KeyboardLayout.Instance.BlackKeys.IndexOf(key));
        }

        internal static Note GetNoteAtIndex(this ObservableCollection<Note> notes, int index)
        {
            if (index >= 0 && index < notes.Count && !notes[index].Name.Equals("-"))
                return notes[index];
            else
                return null;
        }
    }
}
