using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing User Personal Assistant Exclusion Number description.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f53ece1c00394ef2d3d76f532f9a9663:282""}]")]
    public class UserPersonalAssistantExclusionNumberModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:282")]
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

        private string _exclusionNumber;

        [XmlElement(ElementName = "exclusionNumber", IsNullable = false, Namespace = "")]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:282")]
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
        public bool ExclusionNumberSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:282")]
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
        public bool DescriptionSpecified { get; set; }

    }
}
