using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user id of a real or virtual user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2607""}]")]
    public class UserModifyUserIdRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2607")]
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

        private string _newUserId;

        [XmlElement(ElementName = "newUserId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2607")]
        [MinLength(1)]
        [MaxLength(161)]
        public string NewUserId
        {
            get => _newUserId;
            set
            {
                NewUserIdSpecified = true;
                _newUserId = value;
            }
        }

        [XmlIgnore]
        protected bool NewUserIdSpecified { get; set; }

    }
}
