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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bd221784ebf8af2fe1169d36a6ac2dd:303""}]")]
    public class UserPersonalAssistantExclusionNumberGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserPersonalAssistantExclusionNumberGetResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:303")]
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

        protected string _exclusionNumber;

        [XmlElement(ElementName = "exclusionNumber", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:303")]
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
