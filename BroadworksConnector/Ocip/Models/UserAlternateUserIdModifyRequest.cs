using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify an alternate user id of a user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:475""}]")]
    public class UserAlternateUserIdModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:475")]
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

        protected string _alternateUserId;

        [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:475")]
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

        protected string _newAlternateUserId;

        [XmlElement(ElementName = "newAlternateUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:475")]
        [MinLength(1)]
        [MaxLength(161)]
        public string NewAlternateUserId
        {
            get => _newAlternateUserId;
            set
            {
                NewAlternateUserIdSpecified = true;
                _newAlternateUserId = value;
            }
        }

        [XmlIgnore]
        protected bool NewAlternateUserIdSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:475")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

    }
}
