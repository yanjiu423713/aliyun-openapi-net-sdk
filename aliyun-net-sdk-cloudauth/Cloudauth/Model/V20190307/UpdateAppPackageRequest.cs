/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class UpdateAppPackageRequest : RpcAcsRequest<UpdateAppPackageResponse>
    {
        public UpdateAppPackageRequest()
            : base("Cloudauth", "2019-03-07", "UpdateAppPackage", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private bool? debug;

		private string platform;

		private string packageUrl;

		private long? id;

		public bool? Debug
		{
			get
			{
				return debug;
			}
			set	
			{
				debug = value;
				DictionaryUtil.Add(QueryParameters, "Debug", value.ToString());
			}
		}

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
			}
		}

		public string PackageUrl
		{
			get
			{
				return packageUrl;
			}
			set	
			{
				packageUrl = value;
				DictionaryUtil.Add(QueryParameters, "PackageUrl", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateAppPackageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateAppPackageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
