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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16916""}]")]
    public class SystemSIPAuthenticationTrunkGroupLockoutClearRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.TrunkGroupKey> _trunkGroupkey = new List<BroadWorksConnector.Ocip.Models.TrunkGroupKey>();

        [XmlElement(ElementName = "trunkGroupkey", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16916")]
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
