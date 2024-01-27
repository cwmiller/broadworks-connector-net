using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPBXIntegrationGetRequest.
    /// <see cref="UserPBXIntegrationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2760""}]")]
    public class UserPBXIntegrationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _proxyToHeaderFromNetwork;

        [XmlElement(ElementName = "proxyToHeaderFromNetwork", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2760")]
        public bool ProxyToHeaderFromNetwork
        {
            get => _proxyToHeaderFromNetwork;
            set
            {
                ProxyToHeaderFromNetworkSpecified = true;
                _proxyToHeaderFromNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyToHeaderFromNetworkSpecified { get; set; }

    }
}
