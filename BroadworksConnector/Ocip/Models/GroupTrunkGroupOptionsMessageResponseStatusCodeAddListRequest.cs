using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of trunk group level successful SIP OPTIONS message respoonse status codes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1453""}]")]
    public class GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1453")]
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

        private List<string> _statusCode = new List<string>();

        [XmlElement(ElementName = "statusCode", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1453")]
        [MinLength(3)]
        [MaxLength(40)]
        public List<string> StatusCode
        {
            get => _statusCode;
            set
            {
                StatusCodeSpecified = true;
                _statusCode = value;
            }
        }

        [XmlIgnore]
        protected bool StatusCodeSpecified { get; set; }

    }
}
