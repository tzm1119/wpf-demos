#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;

using System.IO;
using Syncfusion.UI.Xaml.Spreadsheet;

namespace AdvancedConditionalFormatting.Behavior
{
    class ImportBehavior : Behavior<SfSpreadsheet>
    {
        protected override void OnAttached()
        {
             this.AssociatedObject.Loaded += new System.Windows.RoutedEventHandler(AssociatedObject_Loaded);
        }

        void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
#if NETCORE
                using (FileStream fileStream = new FileStream(@"..\..\..\..\..\..\Common\Data\Spreadsheet\AdvancedConditionalFormatting.xlsx", FileMode.Open))
#else
				using (FileStream fileStream = new FileStream(@"..\..\..\..\..\Common\Data\Spreadsheet\AdvancedConditionalFormatting.xlsx", FileMode.Open))
#endif
                {
                    this.AssociatedObject.Open(fileStream);
                }
            }
            catch (Exception)
            { }
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= new System.Windows.RoutedEventHandler(AssociatedObject_Loaded);
        }
    }
}
