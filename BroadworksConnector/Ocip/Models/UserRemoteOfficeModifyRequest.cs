using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Remote Office.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""dbef84b1c59b67471031e429db8fd980:73""}]")]
    public class UserRemoteOfficeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"dbef84b1c59b67471031e429db8fd980:73")]
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

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"dbef84b1c59b67471031e429db8fd980:73")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected string _remoteOfficePhoneNumber;

        [XmlElement(ElementName = "remoteOfficePhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"dbef84b1c59b67471031e429db8fd980:73")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RemoteOfficePhoneNumber
        {
            get => _remoteOfficePhoneNumber;
            set
            {
                RemoteOfficePhoneNumberSpecified = true;
                _remoteOfficePhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool RemoteOfficePhoneNumberSpecified { get; set; }

    }
}
