using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderZoneCallingRestrictionsGetRequest
    /// <see cref="ServiceProviderZoneCallingRestrictionsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da5cd0d79ddb505982e08d164e405660:61""}]")]
    public class ServiceProviderZoneCallingRestrictionsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableZoneCallingRestrictions;

        [XmlElement(ElementName = "enableZoneCallingRestrictions", IsNullable = false, Namespace = "")]
        [Group(@"da5cd0d79ddb505982e08d164e405660:61")]
        public bool EnableZoneCallingRestrictions
        {
            get => _enableZoneCallingRestrictions;
            set
            {
                EnableZoneCallingRestrictionsSpecified = true;
                _enableZoneCallingRestrictions = value;
            }
        }

        [XmlIgnore]
        protected bool EnableZoneCallingRestrictionsSpecified { get; set; }

        private bool _enableOriginationRoamingRestrictions;

        [XmlElement(ElementName = "enableOriginationRoamingRestrictions", IsNullable = false, Namespace = "")]
        [Group(@"da5cd0d79ddb505982e08d164e405660:61")]
        public bool EnableOriginationRoamingRestrictions
        {
            get => _enableOriginationRoamingRestrictions;
            set
            {
                EnableOriginationRoamingRestrictionsSpecified = true;
                _enableOriginationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        protected bool EnableOriginationRoamingRestrictionsSpecified { get; set; }

        private bool _enableEmergencyOriginationRoamingRestrictions;

        [XmlElement(ElementName = "enableEmergencyOriginationRoamingRestrictions", IsNullable = false, Namespace = "")]
        [Group(@"da5cd0d79ddb505982e08d164e405660:61")]
        public bool EnableEmergencyOriginationRoamingRestrictions
        {
            get => _enableEmergencyOriginationRoamingRestrictions;
            set
            {
                EnableEmergencyOriginationRoamingRestrictionsSpecified = true;
                _enableEmergencyOriginationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        protected bool EnableEmergencyOriginationRoamingRestrictionsSpecified { get; set; }

        private bool _enableTerminationRoamingRestrictions;

        [XmlElement(ElementName = "enableTerminationRoamingRestrictions", IsNullable = false, Namespace = "")]
        [Group(@"da5cd0d79ddb505982e08d164e405660:61")]
        public bool EnableTerminationRoamingRestrictions
        {
            get => _enableTerminationRoamingRestrictions;
            set
            {
                EnableTerminationRoamingRestrictionsSpecified = true;
                _enableTerminationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTerminationRoamingRestrictionsSpecified { get; set; }

    }
}
