using Microsoft.VisualStudio.DesignTools.Extensibility.Interaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfControlNetCore.Design
{
    class CustomContextMenuProvider : PrimarySelectionContextMenuProvider
    {
        private MenuAction redBackgroundMenuAction;
        private MenuAction whiteBackgroundMenuAction;
        private MenuAction blueBackgroundMenuAction;

        public CustomContextMenuProvider()
        {
            // Set up the MenuAction items
            redBackgroundMenuAction = new MenuAction("Red Background");
            redBackgroundMenuAction.Execute +=
                new EventHandler<MenuActionEventArgs>(RedBackground_Execute);

            whiteBackgroundMenuAction = new MenuAction("White Background");
            whiteBackgroundMenuAction.Execute +=
                new EventHandler<MenuActionEventArgs>(WhiteBackground_Execute);

            blueBackgroundMenuAction = new MenuAction("Blue Background");
            blueBackgroundMenuAction.Execute +=
                new EventHandler<MenuActionEventArgs>(BlueBackground_Execute);

            // Set up the MenuGroup
            MenuGroup myMenuGroup = new MenuGroup("MyMenuGroup", "Custom background");
            myMenuGroup.HasDropDown = false;
            myMenuGroup.Items.Add(redBackgroundMenuAction);
            myMenuGroup.Items.Add(whiteBackgroundMenuAction);
            myMenuGroup.Items.Add(blueBackgroundMenuAction);
            this.Items.Add(myMenuGroup);
        }

        private void RedBackground_Execute(object sender, MenuActionEventArgs e)
        {
            var item = e.Selection.PrimarySelection;
            item.Properties["Background"].SetValue(Brushes.Orange);
        }

        private void WhiteBackground_Execute(object sender, MenuActionEventArgs e)
        {
            var item = e.Selection.PrimarySelection;
            item.Properties["Background"].SetValue(System.Windows.Media.Brushes.White);
        }

        private void BlueBackground_Execute(object sender, MenuActionEventArgs e)
        {
            var item = e.Selection.PrimarySelection;
            item.Properties["Background"].SetValue(System.Windows.Media.Brushes.Blue);
        }

    }
}

