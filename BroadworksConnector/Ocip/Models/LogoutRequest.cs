using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// LogoutRequest is sent when an OCI user logs out or when connection is lost.
    /// This command can be sent either to the server, or to the client from OCS.
    /// The response is either a SuccessResponse or ErrorResponse.
    /// <see cref="LogoutRequest"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef3c4f453d01f7ce750331de83ebc765:345""}]")]
    public class LogoutRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:345")]
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

        protected BroadWorksConnector.Ocip.Models.LogoutRequestReason _reason;

        [XmlElement(ElementName = "reason", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:345")]
        public BroadWorksConnector.Ocip.Models.LogoutRequestReason Reason
        {
            get => _reason;
            set
            {
                ReasonSpecified = true;
                _reason = value;
            }
        }

        [XmlIgnore]
        protected bool ReasonSpecified { get; set; }

    }
}
