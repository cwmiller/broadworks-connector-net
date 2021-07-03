using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Change the user's incoming calling plan settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3dd296d55b56269ae23d86a934b8b35c:130""}]")]
    public class UserIncomingCallingPlanModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:130")]
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
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:130")]
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

        private BroadWorksConnector.Ocip.Models.IncomingCallingPlanPermissionsModify _userPermissions;

        [XmlElement(ElementName = "userPermissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:130")]
        public BroadWorksConnector.Ocip.Models.IncomingCallingPlanPermissionsModify UserPermissions
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
