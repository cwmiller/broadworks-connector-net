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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""70aea661491074f1e7cc845c9a6c7ea3:73""}]")]
    public class UserRemoteOfficeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"70aea661491074f1e7cc845c9a6c7ea3:73")]
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
        public bool UserIdSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"70aea661491074f1e7cc845c9a6c7ea3:73")]
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
        public bool IsActiveSpecified { get; set; }

        private string _remoteOfficePhoneNumber;

        [XmlElement(ElementName = "remoteOfficePhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"70aea661491074f1e7cc845c9a6c7ea3:73")]
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
        public bool RemoteOfficePhoneNumberSpecified { get; set; }

    }
}
