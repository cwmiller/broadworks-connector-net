using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's Portal passcode
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3250""}]")]
    public class UserPortalPasscodeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3250")]
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

        private string _oldPasscode;

        [XmlElement(ElementName = "oldPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3250")]
        [MinLength(1)]
        [MaxLength(30)]
        public string OldPasscode
        {
            get => _oldPasscode;
            set
            {
                OldPasscodeSpecified = true;
                _oldPasscode = value;
            }
        }

        [XmlIgnore]
        protected bool OldPasscodeSpecified { get; set; }

        private string _newPasscode;

        [XmlElement(ElementName = "newPasscode", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3250")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NewPasscode
        {
            get => _newPasscode;
            set
            {
                NewPasscodeSpecified = true;
                _newPasscode = value;
            }
        }

        [XmlIgnore]
        protected bool NewPasscodeSpecified { get; set; }

    }
}
