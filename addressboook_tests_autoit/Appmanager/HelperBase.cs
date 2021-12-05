using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoItX3Lib;


namespace addressboook_tests_autoit
{
    public class HelperBase
    {
        protected AutoItX3 aux;
        protected ApplicationManager manager;
        protected string WINTITLE;
        public HelperBase(ApplicationManager manager)
        {
            WINTITLE = ApplicationManager.WINTITLE;
            this.manager = manager;
            this.aux = manager.Aux;
        }
    }
}