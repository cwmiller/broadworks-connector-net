using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the user assigned Call to Number List information.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// For the callToNumbers in the callToNumberList, the extension element
    /// is not used and the number element is only used when the type is BroadWorks Mobility.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bd221784ebf8af2fe1169d36a6ac2dd:198""}]")]
    public class UserPersonalAssistantCallToNumberModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:198")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementCallToNumberList _callToNumberList;

        [XmlElement(ElementName = "callToNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:198")]
        public BroadWorksConnector.Ocip.Models.ReplacementCallToNumberList CallToNumberList
        {
            get => _callToNumberList;
            set
            {
                CallToNumberListSpecified = true;
                _callToNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool CallToNumberListSpecified { get; set; }

    }
}
