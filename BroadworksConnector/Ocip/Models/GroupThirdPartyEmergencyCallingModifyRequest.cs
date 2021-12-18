using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the third-party emergency call service settings for the Group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8485""}]")]
    public class GroupThirdPartyEmergencyCallingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8485")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8485")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private bool _enableDeviceManagement;

        [XmlElement(ElementName = "enableDeviceManagement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8485")]
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

        private bool _enableRouting;

        [XmlElement(ElementName = "enableRouting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8485")]
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

        private string _customerId;

        [XmlElement(ElementName = "customerId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8485")]
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

        private string _secretKey;

        [XmlElement(ElementName = "secretKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8485")]
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
