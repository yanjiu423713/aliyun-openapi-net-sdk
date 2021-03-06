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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstancesOverviewResponseUnmarshaller
    {
        public static DescribeDBInstancesOverviewResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstancesOverviewResponse describeDBInstancesOverviewResponse = new DescribeDBInstancesOverviewResponse();

			describeDBInstancesOverviewResponse.HttpResponse = context.HttpResponse;
			describeDBInstancesOverviewResponse.RequestId = context.StringValue("DescribeDBInstancesOverview.RequestId");

			List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel> describeDBInstancesOverviewResponse_regions = new List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel>();
			for (int i = 0; i < context.Length("DescribeDBInstancesOverview.Regions.Length"); i++) {
				DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel regionModel = new DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel();
				regionModel.Region = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].Region");
				regionModel.EngineCount = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].EngineCount");
				regionModel.TotalCount = context.IntegerValue("DescribeDBInstancesOverview.Regions["+ i +"].TotalCount");

				List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel.DescribeDBInstancesOverview_TypeModel> regionModel_typeModels = new List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel.DescribeDBInstancesOverview_TypeModel>();
				for (int j = 0; j < context.Length("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels.Length"); j++) {
					DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel.DescribeDBInstancesOverview_TypeModel typeModel = new DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel.DescribeDBInstancesOverview_TypeModel();
					typeModel.InstanceDateType = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceDateType");
					typeModel.Count = context.IntegerValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].Count");

					List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel.DescribeDBInstancesOverview_TypeModel.DescribeDBInstancesOverview_InstanceModel> typeModel_instanceModels = new List<DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel.DescribeDBInstancesOverview_TypeModel.DescribeDBInstancesOverview_InstanceModel>();
					for (int k = 0; k < context.Length("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels.Length"); k++) {
						DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel.DescribeDBInstancesOverview_TypeModel.DescribeDBInstancesOverview_InstanceModel instanceModel = new DescribeDBInstancesOverviewResponse.DescribeDBInstancesOverview_RegionModel.DescribeDBInstancesOverview_TypeModel.DescribeDBInstancesOverview_InstanceModel();
						instanceModel.DBInstanceId = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].DBInstanceId");
						instanceModel.Region = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].Region");
						instanceModel.ZoneId = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].ZoneId");
						instanceModel.Engine = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].Engine");
						instanceModel.PayType = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].PayType");
						instanceModel.CreatedTime = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].CreatedTime");
						instanceModel.ExpireTime = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].ExpireTime");
						instanceModel.LockMode = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].LockMode");
						instanceModel.DBInstanceStatus = context.StringValue("DescribeDBInstancesOverview.Regions["+ i +"].TypeModels["+ j +"].InstanceModels["+ k +"].DBInstanceStatus");

						typeModel_instanceModels.Add(instanceModel);
					}
					typeModel.InstanceModels = typeModel_instanceModels;

					regionModel_typeModels.Add(typeModel);
				}
				regionModel.TypeModels = regionModel_typeModels;

				describeDBInstancesOverviewResponse_regions.Add(regionModel);
			}
			describeDBInstancesOverviewResponse.Regions = describeDBInstancesOverviewResponse_regions;
        
			return describeDBInstancesOverviewResponse;
        }
    }
}
