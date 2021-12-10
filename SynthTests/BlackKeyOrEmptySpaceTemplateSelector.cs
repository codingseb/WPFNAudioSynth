using System.Windows;
using System.Windows.Controls;

namespace SynthTests
{
    public class BlackKeyOrEmptySpaceTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BlackKeyTemplate { get; set; }

        public DataTemplate EmptySpaceTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if(item is Note note && !note.Name.Equals("-"))
            {
                return BlackKeyTemplate;
            }
            else
            {
                return EmptySpaceTemplate;
            }
        }
    }
}
