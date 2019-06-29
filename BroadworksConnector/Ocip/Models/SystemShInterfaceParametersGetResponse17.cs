using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemShInterfaceParametersGetRequest.  Contains the Sh Interface system parameters.
    /// <see cref="SystemShInterfaceParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15257""}]")]
    public class SystemShInterfaceParametersGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _hssRealm;

        [XmlElement(ElementName = "hssRealm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15257")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15257")]
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
