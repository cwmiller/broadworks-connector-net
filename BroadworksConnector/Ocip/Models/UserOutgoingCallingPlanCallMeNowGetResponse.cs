using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserOutgoingCallingPlanCallMeNowGetRequest.
    /// <see cref="UserOutgoingCallingPlanCallMeNowGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1146""}]")]
    public class UserOutgoingCallingPlanCallMeNowGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useCustomSettings;

        [XmlElement(ElementName = "useCustomSettings", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1146")]
        public bool UseCustomSettings
        {
            get => _useCustomSettings;
            set
            {
                UseCustomSettingsSpecified = true;
                _useCustomSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseCustomSettingsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions _userPermissions;

        [XmlElement(ElementName = "userPermissions", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1146")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions UserPermissions
        {
            get => _userPermissions;
            set
            {
                UserPermissionsSpecified = true;
                _userPermissions = value;
            }
        }

        [XmlIgnore]
        public bool UserPermissionsSpecified { get; set; }

    }
}
