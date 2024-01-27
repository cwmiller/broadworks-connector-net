using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest.
    /// <see cref="UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:1396""}]")]
    public class UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useCustomSettings;

        [XmlElement(ElementName = "useCustomSettings", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1396")]
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
        protected bool UseCustomSettingsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermissions _userPermissions;

        [XmlElement(ElementName = "userPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1396")]
        public BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermissions UserPermissions
        {
            get => _userPermissions;
            set
            {
                UserPermissionsSpecified = true;
                _userPermissions = value;
            }
        }

        [XmlIgnore]
        protected bool UserPermissionsSpecified { get; set; }

    }
}
