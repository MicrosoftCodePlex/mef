﻿using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Composition.Demos.DefaultOnly.Extension
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class DefaultExportAttribute : ExportAttribute
    {
        public DefaultExportAttribute(Type contractType)
            : base(Constants.DefaultContractNamePrefix, contractType) { }

        public DefaultExportAttribute(string contractName, Type contractType)
            : base(Constants.DefaultContractNamePrefix + contractName, contractType) { }
    }
}
