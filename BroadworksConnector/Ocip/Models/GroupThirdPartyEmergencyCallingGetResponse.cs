using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupThirdPartyEmergencyCallingGetRequest.
    /// The response contains the third-party emergency call service settings for the Group.
    /// <see cref="GroupThirdPartyEmergencyCallingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:13350""}]")]
    public class GroupThirdPartyEmergencyCallingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableDeviceManagement;

        [XmlElement(ElementName = "enableDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:13350")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:13350")]
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

    }
}
