using System;
using Microsoft.Windows.Design;
using Microsoft.Windows.Design.Features;
using Microsoft.Windows.Design.Metadata;

// The ProvideMetadata assembly-level attribute indicates to designers
// that this assembly contains a class that provides an attribute table. 
[assembly: ProvideMetadata(typeof(WpfControlNetFramework.Design.RegisterMetaData))]

namespace WpfControlNetFramework.Design
{
    public class RegisterMetaData : IProvideAttributeTable
    {
        public AttributeTable AttributeTable
        {
            get
            {
                AttributeTableBuilder builder = new AttributeTableBuilder();

                // Add the menu provider to the design-time metadata.
                builder.AddCustomAttributes(
                    typeof(WpfControlNetFramework.ButtonWithDesignTime),
                    new FeatureAttribute(typeof(CustomContextMenuProvider)));

                return builder.CreateTable();
            }
        }
    }
}

