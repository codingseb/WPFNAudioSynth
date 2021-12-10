using System.Windows;
using System.Windows.Input;

namespace SynthTests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is FrameworkElement fe && fe.DataContext is Note note)
            {
                note.InPlay = true;
            }
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement fe && fe.DataContext is Note note)
            {
                note.InPlay = false;
            }
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is FrameworkElement fe && fe.DataContext is Note note)
            {
                note.InPlay = false;
            }
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && sender is FrameworkElement fe && fe.DataContext is Note note)
            {
                note.InPlay = true;
            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(KeyboardLayout.Instance.WhiteKeys.Contains(e.Key))
            {
                int index = KeyboardLayout.Instance.WhiteKeys.IndexOf(e.Key);

                if (index >= 0 && index < Notes.BaseNotes.Count)
            }
            else if(KeyboardLayout.Instance.BlackKeys.Contains(e.Key))
            {
                int index = KeyboardLayout.Instance.WhiteKeys.IndexOf(e.Key);
            }
        }

        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {

        }

        private Note GetNoteFromKeyboardKey(Key key)
        {
            if (KeyboardLayout.Instance.WhiteKeys.Contains(key))
            {
                int index = KeyboardLayout.Instance.WhiteKeys.IndexOf(key);

                if (index >= 0 && index < Notes.BaseNotes.Count)
                    return Notes.BaseNotes[index];
            }
            else if (KeyboardLayout.Instance.BlackKeys.Contains(key))
            {
                int index = KeyboardLayout.Instance.BlackKeys.IndexOf(key);



            }
        }
    }
}
