using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a Personal Assistant Exclusion Number.
    /// The response is either UserPersonalAssistantExclusionNumberGetResponse or ErrorResponse.
    /// <see cref="UserPersonalAssistantExclusionNumberGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f53ece1c00394ef2d3d76f532f9a9663:251""}]")]
    public class UserPersonalAssistantExclusionNumberGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserPersonalAssistantExclusionNumberGetResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:251")]
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

        private string _exclusionNumber;

        [XmlElement(ElementName = "exclusionNumber", IsNullable = false, Namespace = "")]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:251")]
        [MinLength(1)]
        [MaxLength(23)]
        public string ExclusionNumber
        {
            get => _exclusionNumber;
            set
            {
                ExclusionNumberSpecified = true;
                _exclusionNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ExclusionNumberSpecified { get; set; }

    }
}
