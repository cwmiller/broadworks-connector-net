using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a criteria for the user's call forwarding selective service.
    /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse16 or an ErrorResponse.
    /// Replaced by: UserCallForwardingSelectiveGetCriteriaRequest21 in AS data mode
    /// <see cref="UserCallForwardingSelectiveGetCriteriaResponse16"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCallForwardingSelectiveGetCriteriaRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:16837""}]")]
    public class UserCallForwardingSelectiveGetCriteriaRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCallForwardingSelectiveGetCriteriaResponse16>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:16837")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:16837")]
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
