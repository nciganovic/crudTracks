using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class OperationResult
    {
        public bool IsSuccessfull => !Errors.Any();
        public IEnumerable<Dto> Data { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
