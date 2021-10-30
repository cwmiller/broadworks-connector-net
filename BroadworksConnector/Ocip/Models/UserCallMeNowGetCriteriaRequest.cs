using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a criteria for the user's call me now service.
    /// The response is either a UserCallMeNowGetCriteriaResponse or an ErrorResponse.
    /// <see cref="UserCallMeNowGetCriteriaResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1f0f230fee2817fe00157925859dc28e:132""}]")]
    public class UserCallMeNowGetCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCallMeNowGetCriteriaResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1f0f230fee2817fe00157925859dc28e:132")]
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

        private string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"1f0f230fee2817fe00157925859dc28e:132")]
        [MinLength(1)]
        [MaxLength(50)]
        public string CriteriaName
        {
            get => _criteriaName;
            set
            {
                CriteriaNameSpecified = true;
                _criteriaName = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaNameSpecified { get; set; }

    }
}
