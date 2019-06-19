using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the Sh Interface system parameters. This request must be submitted on both nodes in the
    /// redundant Application Server cluster in order for the changes to take effect on each node without
    /// requiring a restart.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemShInterfaceParametersModifyRequest17
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemShInterfaceParametersModifyRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15976""}]")]
    public class SystemShInterfaceParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _hssRealm;

        [XmlElement(ElementName = "hssRealm", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15976")]
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
        public bool HssRealmSpecified { get; set; }

        private int _requestTimeoutSeconds;

        [XmlElement(ElementName = "requestTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15976")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int RequestTimeoutSeconds
        {
            get => _requestTimeoutSeconds;
            set
            {
                RequestTimeoutSecondsSpecified = true;
                _requestTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RequestTimeoutSecondsSpecified { get; set; }

        private int _publicIdentityRefreshDelaySeconds;

        [XmlElement(ElementName = "publicIdentityRefreshDelaySeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15976")]
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
        public bool PublicIdentityRefreshDelaySecondsSpecified { get; set; }

    }
}
