using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a criteria for the user's simultaneous ring family service.
    /// The response is either a UserSimultaneousRingFamilyGetCriteriaResponse or an ErrorResponse.
    /// <see cref="UserSimultaneousRingFamilyGetCriteriaResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7829cd70c5c6e02768e0a59a5de29efe:85""}]")]
    public class UserSimultaneousRingFamilyGetCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserSimultaneousRingFamilyGetCriteriaResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"7829cd70c5c6e02768e0a59a5de29efe:85")]
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

        protected string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"7829cd70c5c6e02768e0a59a5de29efe:85")]
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
