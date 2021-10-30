using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to clear sip authentication trunk group lockouts in the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16696""}]")]
    public class SystemSIPAuthenticationTrunkGroupLockoutClearRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private List<BroadWorksConnector.Ocip.Models.TrunkGroupKey> _trunkGroupkey = new List<BroadWorksConnector.Ocip.Models.TrunkGroupKey>();

        [XmlElement(ElementName = "trunkGroupkey", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16696")]
        public List<BroadWorksConnector.Ocip.Models.TrunkGroupKey> TrunkGroupkey
        {
            get => _trunkGroupkey;
            set
            {
                TrunkGroupkeySpecified = true;
                _trunkGroupkey = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupkeySpecified { get; set; }

    }
}
