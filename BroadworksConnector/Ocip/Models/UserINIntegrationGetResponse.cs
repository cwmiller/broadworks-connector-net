using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserINIntegrationGetRequest
    /// <see cref="UserINIntegrationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""841786e27ac49a43576369a93b4cc726:56""}]")]
    public class UserINIntegrationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _originatingServiceKey;

        [XmlElement(ElementName = "originatingServiceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"841786e27ac49a43576369a93b4cc726:56")]
        [MinInclusive(0)]
        [MaxInclusive(999)]
        public int OriginatingServiceKey
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

        protected int _terminatingServiceKey;

        [XmlElement(ElementName = "terminatingServiceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"841786e27ac49a43576369a93b4cc726:56")]
        [MinInclusive(0)]
        [MaxInclusive(999)]
        public int TerminatingServiceKey
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
