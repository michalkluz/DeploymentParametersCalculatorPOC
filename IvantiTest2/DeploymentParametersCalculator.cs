using System;
using System.Collections.Generic;

namespace IvantiTest2
{
    public static class DeploymentParametersCalculator
    {
        public static DeploymentParameters GetAllParameters(AllDeployments allDeployments, DateTime relevantYear)
        {
            var deploymentsToProdInAYear = new List<Deployment>();
            var successfulDeploymentsToProdInAYear = new List<Deployment>();
            foreach (Deployment deployment in allDeployments.Deployment)
            {
                var isProduction = deployment.ReleaseEnvironment.Name == "PROD";
                var isRelevantYear = deployment.StartedOn.DateTime >= relevantYear && deployment.StartedOn.DateTime <= relevantYear.AddYears(1);
                if (isProduction && isRelevantYear)
                {
                    deploymentsToProdInAYear.Add(deployment);

                    var isSucceeded = deployment.DeploymentStatus == DeploymentStatus.Succeeded;
                    if (isSucceeded)
                    {
                        successfulDeploymentsToProdInAYear.Add(deployment);
                    }
                }
            }

            float changeFailureRate = (((float)deploymentsToProdInAYear.Count - (float)successfulDeploymentsToProdInAYear.Count) / (float)deploymentsToProdInAYear.Count) * 100;

            return new DeploymentParameters
            {
                DeploymentFrequency = successfulDeploymentsToProdInAYear.Count,
                ChangeFailureRate = changeFailureRate
            };
        }
    }
}
    
