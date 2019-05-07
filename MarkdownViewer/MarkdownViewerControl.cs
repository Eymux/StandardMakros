using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;

namespace MarkdownViewer
{
    class MarkdownViewerControl : FlowDocumentScrollViewer
    {
        private string text = "";

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;

                string html = Markdig.Markdown.ToHtml(text);
                string xaml = HTMLConverter.HtmlToXamlConverter.ConvertHtmlToXaml(html, true);

                StringReader stringReader = new StringReader(xaml);
                System.Xml.XmlReader xmlReader = System.Xml.XmlReader.Create(stringReader);
                Document  = XamlReader.Load(xmlReader) as FlowDocument;
            }
        }

        public MarkdownViewerControl()
        {
            this.Document = new FlowDocument();
        }
    }
}
