using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemShInterfaceParametersGetRequest.  Contains the Sh Interface system parameters.
    /// 
    /// Replaced by: SystemShInterfaceParametersGetResponse17
    /// <see cref="SystemShInterfaceParametersGetRequest"/>
    /// <see cref="SystemShInterfaceParametersGetResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29965""}]")]
    public class SystemShInterfaceParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _hssRealm;

        [XmlElement(ElementName = "hssRealm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:29965")]
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

        protected int _requestTimeoutSeconds;

        [XmlElement(ElementName = "requestTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29965")]
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
        protected bool RequestTimeoutSecondsSpecified { get; set; }

        protected int _publicIdentityRefreshDelaySeconds;

        [XmlElement(ElementName = "publicIdentityRefreshDelaySeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:29965")]
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
