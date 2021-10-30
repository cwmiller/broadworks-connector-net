using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete an alternate admin user id of a reseller admin.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:135""}]")]
    public class ResellerAdminAlternateIdDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:135")]
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

        private string _alternateUserId;

        [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:135")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AlternateUserId
        {
            get => _alternateUserId;
            set
            {
                AlternateUserIdSpecified = true;
                _alternateUserId = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateUserIdSpecified { get; set; }

    }
}
