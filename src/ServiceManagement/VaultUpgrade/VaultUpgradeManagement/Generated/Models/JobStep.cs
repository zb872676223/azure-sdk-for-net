// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.VaultUpgrade.Models
{
    /// <summary>
    /// The definition of job steps.
    /// </summary>
    public partial class JobStep
    {
        private string _detail;
        
        /// <summary>
        /// Optional. Job details.
        /// </summary>
        public string Detail
        {
            get { return this._detail; }
            set { this._detail = value; }
        }
        
        private string _message;
        
        /// <summary>
        /// Optional. Associated message.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private string _operationResult;
        
        /// <summary>
        /// Optional. Operation's result.
        /// </summary>
        public string OperationResult
        {
            get { return this._operationResult; }
            set { this._operationResult = value; }
        }
        
        private string _operationStatus;
        
        /// <summary>
        /// Optional. Operation's status.
        /// </summary>
        public string OperationStatus
        {
            get { return this._operationStatus; }
            set { this._operationStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobStep class.
        /// </summary>
        public JobStep()
        {
        }
    }
}
