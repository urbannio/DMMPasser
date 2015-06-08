using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading.Tasks;
using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;

namespace DMMPasser
{
    [Export(typeof(IToolPlugin))]
    [ExportMetadata("Title", "DMMPasser")]
    [ExportMetadata("Description", "Pass DMM by edit cookies")]
    [ExportMetadata("Version", "2.0")]
    [ExportMetadata("Author", "@Urbannio")]
    public class DMMPasser : IToolPlugin
    {
       
        public string ToolName
        {
            get { return "DMMPasser"; }
        }

        public object GetSettingsView()
        {
            return null;
        }

        public object GetToolView()
        {
            return new PasserView { };
        }
    }


   
}
