using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ServicePolicyProfileCategory{
    CallProcessingParameters,
    CallTypesMapping,
    ConfigurableTreatments,
    ExternalEmergencyRoutingParameters,
    GETS,
    ProvisioningValidation,
    Services,
    ServiceCodes,
 }
}
