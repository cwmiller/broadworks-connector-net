using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's Voice Portal password
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// Replaced By: UserPortalPasscodeModifyRequest
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserPortalPasscodeModifyRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47305""}]")]
    public class UserVoiceMessagingUserModifyVoicePortalPasswordRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47305")]
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

        private string _oldPassword;

        [XmlElement(ElementName = "oldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47305")]
        [MinLength(1)]
        [MaxLength(60)]
        public string OldPassword
        {
            get => _oldPassword;
            set
            {
                OldPasswordSpecified = true;
                _oldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool OldPasswordSpecified { get; set; }

        private string _newPassword;

        [XmlElement(ElementName = "newPassword", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47305")]
        [MinLength(1)]
        [MaxLength(60)]
        public string NewPassword
        {
            get => _newPassword;
            set
            {
                NewPasswordSpecified = true;
                _newPassword = value;
            }
        }

        [XmlIgnore]
        protected bool NewPasswordSpecified { get; set; }

    }
}
