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
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="LogoutRequest"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:403""}]")]
    public class LogoutRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:403")]
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

        private BroadWorksConnector.Ocip.Models.LogoutRequestReason _reason;

        [XmlElement(ElementName = "reason", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:403")]
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
        public bool ReasonSpecified { get; set; }

    }
}
