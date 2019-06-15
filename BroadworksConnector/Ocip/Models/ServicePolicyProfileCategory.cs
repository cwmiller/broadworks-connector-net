using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The service policy profile categories.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServicePolicyProfileCategory    {
            [XmlEnum(Name = "Call Processing Parameters")]
        CallProcessingParameters,
            [XmlEnum(Name = "Call Types Mapping")]
        CallTypesMapping,
            [XmlEnum(Name = "Configurable Treatments")]
        ConfigurableTreatments,
            [XmlEnum(Name = "External Emergency Routing Parameters")]
        ExternalEmergencyRoutingParameters,
            [XmlEnum(Name = "GETS")]
        GETS,
            [XmlEnum(Name = "Provisioning Validation")]
        ProvisioningValidation,
            [XmlEnum(Name = "Services")]
        Services,
            [XmlEnum(Name = "Service Codes")]
        ServiceCodes,
     }
}
