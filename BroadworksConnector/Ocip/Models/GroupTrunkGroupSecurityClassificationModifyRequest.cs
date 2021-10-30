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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:85""}]")]
    public class GroupTrunkGroupSecurityClassificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:85")]
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

        private string _defaultSecurityClassification;

        [XmlElement(ElementName = "defaultSecurityClassification", IsNullable = true, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:85")]
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
