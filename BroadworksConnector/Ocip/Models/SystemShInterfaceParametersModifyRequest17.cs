using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the Sh Interface system parameters.  This request must be submitted on both nodes in the redundant Application Server cluster in order for the changes to take effect on each node without requiring a restart.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16422""}]")]
    public class SystemShInterfaceParametersModifyRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _hssRealm;

        [XmlElement(ElementName = "hssRealm", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16422")]
        [MinLength(1)]
        [MaxLength(80)]
        public string HssRealm
        {
            get => _hssRealm;
            set
            {
                HssRealmSpecified = true;
                _hssRealm = value;
            }
        }

        [XmlIgnore]
        protected bool HssRealmSpecified { get; set; }

        private int _publicIdentityRefreshDelaySeconds;

        [XmlElement(ElementName = "publicIdentityRefreshDelaySeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16422")]
        [MinInclusive(0)]
        [MaxInclusive(30)]
        public int PublicIdentityRefreshDelaySeconds
        {
            get => _publicIdentityRefreshDelaySeconds;
            set
            {
                PublicIdentityRefreshDelaySecondsSpecified = true;
                _publicIdentityRefreshDelaySeconds = value;
            }
        }

        [XmlIgnore]
        protected bool PublicIdentityRefreshDelaySecondsSpecified { get; set; }

    }
}
