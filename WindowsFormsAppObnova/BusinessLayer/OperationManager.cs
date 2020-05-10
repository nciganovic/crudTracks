using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class OperationManager
    {
        private static OperationManager _singleton;

        private OperationManager() { 
        
        }

        public OperationResult Exec(Operation op) {
            try
            {
                return op.Execute();
            }
            catch (Exception exp) {
                LogException(exp);
                var result = new OperationResult();
                result.Errors.Add("Error occured.");
                return result;
            }
        }

        public void LogException(Exception exp) {
            Console.WriteLine(exp.Message);
        }

        public static OperationManager Instance {
            get {
                if (_singleton == null) {
                    _singleton = new OperationManager();
                }

                return _singleton;
            }
        }
    }
}
