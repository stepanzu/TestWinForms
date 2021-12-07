using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interfaces
{
    interface IController
    {
        void init();
        void RunApplication();
        void InitListeners();
        void PopulateInitialDataGrids();
        void PrepareDataGrids();
        void HideRelationalFields();
    }
}
