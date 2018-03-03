using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;

namespace SSISComponents.ReportGenerator
{
    class ReportGeneratorUiInterface : IDtsTaskUI
    {
        #region Private Variables
        private TaskHost _taskHost;
        private Connections _connections;
        #endregion

        #region Constructor

        #endregion

        #region IDtsTaskUI Interface
        public void Initialize(TaskHost taskHost, IServiceProvider serviceProvider)
        {
            // Store references to the task and connection metadata.
            _taskHost = taskHost;
            var cs = serviceProvider.GetService(typeof(IDtsConnectionService)) as IDtsConnectionService;
            if (cs != null) _connections = cs.GetConnections();
        }

        public ContainerControl GetView()
        {
            // Launch your editor with information from your task and available connections
            return new ReportGeneratorUi(_taskHost, _connections);
        }

        public void Delete(IWin32Window parentWindow)
        {
        }

        public void New(IWin32Window parentWindow)
        {
        }
        #endregion
    }
}
