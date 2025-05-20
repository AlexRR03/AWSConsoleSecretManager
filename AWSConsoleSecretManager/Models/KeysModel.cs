using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSConsoleSecretManager.Models
{
    public class KeysModel
    {
        public string MySql { get; set; }
        public string Bucket { get; set; }
        public string Api { get; set; }
    }
}
