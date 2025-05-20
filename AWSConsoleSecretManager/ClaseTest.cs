using AWSConsoleSecretManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSConsoleSecretManager
{
    public class ClaseTest
    {
        private KeysModel keysModel;
        public ClaseTest(KeysModel keysModel)
        {
            this.keysModel = keysModel;
        }
        public string GetApiVulue()
        {
            return keysModel.Api;
        }
    }
}
