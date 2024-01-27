using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a trunk group's Security Classification configuration
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""435c279b3e6710f4ada60ed66a93d278:85""}]")]
    public class GroupTrunkGroupSecurityClassificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:85")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey
        {
            get => _trunkGroupKey;
            set
            {
                TrunkGroupKeySpecified = true;
                _trunkGroupKey = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupKeySpecified { get; set; }

        protected string _defaultSecurityClassification;

        [XmlElement(ElementName = "defaultSecurityClassification", IsNullable = true, Namespace = "")]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:85")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DefaultSecurityClassification
        {
            get => _defaultSecurityClassification;
            set
            {
                DefaultSecurityClassificationSpecified = true;
                _defaultSecurityClassification = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultSecurityClassificationSpecified { get; set; }

    }
}
