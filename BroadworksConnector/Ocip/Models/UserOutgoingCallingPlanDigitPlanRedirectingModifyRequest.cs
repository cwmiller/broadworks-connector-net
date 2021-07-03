using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the redirecting permissions for digit patterns for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1314""}]")]
    public class UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1314")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private bool _useCustomSettings;

        [XmlElement(ElementName = "useCustomSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1314")]
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

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermissions _userPermissions;

        [XmlElement(ElementName = "userPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1314")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermissions UserPermissions
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
