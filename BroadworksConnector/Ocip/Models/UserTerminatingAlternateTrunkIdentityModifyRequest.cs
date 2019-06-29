using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Terminating Alternate Trunk Identity.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4007""}]")]
    public class UserTerminatingAlternateTrunkIdentityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4007")]
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

        private string _terminatingTrunkIdentity;

        [XmlElement(ElementName = "terminatingTrunkIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4007")]
        [MinLength(1)]
        [MaxLength(80)]
        public string TerminatingTrunkIdentity
        {
            get => _terminatingTrunkIdentity;
            set
            {
                TerminatingTrunkIdentitySpecified = true;
                _terminatingTrunkIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool TerminatingTrunkIdentitySpecified { get; set; }

    }
}
