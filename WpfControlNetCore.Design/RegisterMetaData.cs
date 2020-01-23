using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Windows.Design.Features;
using Microsoft.Windows.Design.Metadata;

// The ProvideMetadata assembly-level attribute indicates to designers
// that this assembly contains a class that provides an attribute table. 
[assembly: ProvideMetadata(typeof(WpfControlNetCore.Design.RegisterMetaData))]

namespace WpfControlNetCore.Design
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
                    typeof(WpfControlNetCore.ButtonWithDesignTime),
                    new FeatureAttribute(typeof(CustomContextMenuProvider)));

                return builder.CreateTable();
            }
        }
    }
}

