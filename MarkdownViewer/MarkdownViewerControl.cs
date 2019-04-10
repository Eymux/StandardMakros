using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace MarkdownViewer
{
    class MarkdownViewerControl : FlowDocumentScrollViewer
    {
        public MarkdownViewerControl()
        {
            this.Document = new FlowDocument();
            var para = new Paragraph();
            para.Inlines.Add("Hello World!");
            this.Document.Blocks.Add(para);
            //var viewer = new StackPanel();
            //viewer.MinWidth = 100;
            //viewer.MinHeight = 100;
            //viewer.HorizontalAlignment = HorizontalAlignment.Stretch;
            //viewer.VerticalAlignment = VerticalAlignment.Stretch;
            //viewer.Background = new SolidColorBrush(Color.FromRgb(1, 0, 0));
            //this.AddVisualChild(viewer);
        }
    }
}
