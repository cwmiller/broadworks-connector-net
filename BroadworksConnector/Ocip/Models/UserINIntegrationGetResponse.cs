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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2b7b9ea45350592016ce6935a4d7694:56""}]")]
    public class UserINIntegrationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _originatingServiceKey;

        [XmlElement(ElementName = "originatingServiceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2b7b9ea45350592016ce6935a4d7694:56")]
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

        private int _terminatingServiceKey;

        [XmlElement(ElementName = "terminatingServiceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2b7b9ea45350592016ce6935a4d7694:56")]
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
