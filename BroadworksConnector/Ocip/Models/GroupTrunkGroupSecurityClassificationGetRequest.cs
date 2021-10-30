using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a trunk group's Security Classifications configuration.
    /// The response is either GroupTrunkGroupSecurityClassificationGetResponse or ErrorResponse.
    /// <see cref="GroupTrunkGroupSecurityClassificationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:54""}]")]
    public class GroupTrunkGroupSecurityClassificationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupTrunkGroupSecurityClassificationGetResponse>
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:54")]
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

    }
}
