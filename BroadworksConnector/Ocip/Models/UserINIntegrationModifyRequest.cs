using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the user level IN Integration service attributes
    /// The response is either SuccessResponse or ErrorResponse
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2b7b9ea45350592016ce6935a4d7694:73""}]")]
    public class UserINIntegrationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"e2b7b9ea45350592016ce6935a4d7694:73")]
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

        protected int? _originatingServiceKey;

        [XmlElement(ElementName = "originatingServiceKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2b7b9ea45350592016ce6935a4d7694:73")]
        [MinInclusive(0)]
        [MaxInclusive(999)]
        public int? OriginatingServiceKey
        {
            get => _originatingServiceKey;
            set
            {
                OriginatingServiceKeySpecified = true;
                _originatingServiceKey = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatingServiceKeySpecified { get; set; }

        protected int? _terminatingServiceKey;

        [XmlElement(ElementName = "terminatingServiceKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2b7b9ea45350592016ce6935a4d7694:73")]
        [MinInclusive(0)]
        [MaxInclusive(999)]
        public int? TerminatingServiceKey
        {
            get => _terminatingServiceKey;
            set
            {
                TerminatingServiceKeySpecified = true;
                _terminatingServiceKey = value;
            }
        }

        [XmlIgnore]
        protected bool TerminatingServiceKeySpecified { get; set; }

    }
}
