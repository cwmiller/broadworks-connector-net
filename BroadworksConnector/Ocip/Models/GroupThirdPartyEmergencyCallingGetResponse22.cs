using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupThirdPartyEmergencyCallingGetRequest22.
    /// The response contains the third-party emergency call service settings for the Group.
    /// <see cref="GroupThirdPartyEmergencyCallingGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:8180""}]")]
    public class GroupThirdPartyEmergencyCallingGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableDeviceManagement;

        [XmlElement(ElementName = "enableDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8180")]
        public bool EnableDeviceManagement
        {
            get => _enableDeviceManagement;
            set
            {
                EnableDeviceManagementSpecified = true;
                _enableDeviceManagement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDeviceManagementSpecified { get; set; }

        protected bool _enableRouting;

        [XmlElement(ElementName = "enableRouting", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8180")]
        public bool EnableRouting
        {
            get => _enableRouting;
            set
            {
                EnableRoutingSpecified = true;
                _enableRouting = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRoutingSpecified { get; set; }

        protected string _customerId;

        [XmlElement(ElementName = "customerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8180")]
        [MinLength(1)]
        [MaxLength(36)]
        public string CustomerId
        {
            get => _customerId;
            set
            {
                CustomerIdSpecified = true;
                _customerId = value;
            }
        }

        [XmlIgnore]
        protected bool CustomerIdSpecified { get; set; }

        protected string _secretKey;

        [XmlElement(ElementName = "secretKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8180")]
        [MinLength(1)]
        [MaxLength(16)]
        public string SecretKey
        {
            get => _secretKey;
            set
            {
                SecretKeySpecified = true;
                _secretKey = value;
            }
        }

        [XmlIgnore]
        protected bool SecretKeySpecified { get; set; }

    }
}
