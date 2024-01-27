using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Reorders only the Schedule Selective Criteria entries.
    /// Criteria entries received in the orderedCriteriaList element are set at the top of the ordered criteria list.
    /// Existing criteria not received in orderedCriteriaList are moved down to a lower priority.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bd221784ebf8af2fe1169d36a6ac2dd:487""}]")]
    public class UserPersonalAssistantReorderCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:487")]
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

        protected BroadWorksConnector.Ocip.Models.OrderedCriteriaList _orderedCriteriaList;

        [XmlElement(ElementName = "orderedCriteriaList", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:487")]
        public BroadWorksConnector.Ocip.Models.OrderedCriteriaList OrderedCriteriaList
        {
            get => _orderedCriteriaList;
            set
            {
                OrderedCriteriaListSpecified = true;
                _orderedCriteriaList = value;
            }
        }

        [XmlIgnore]
        protected bool OrderedCriteriaListSpecified { get; set; }

    }
}
