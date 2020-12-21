using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FodXamarin
{
    [ContentProperty(nameof(source))]
    class ImageRessourceExtension : IMarkupExtension
    {

        public string source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (source == null)
                return null;
            var imageSource = ImageSource.FromResource(source, typeof(ImageRessourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}
