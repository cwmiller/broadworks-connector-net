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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2755""}]")]
    public class UserPBXIntegrationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _proxyToHeaderFromNetwork;

        [XmlElement(ElementName = "proxyToHeaderFromNetwork", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2755")]
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
