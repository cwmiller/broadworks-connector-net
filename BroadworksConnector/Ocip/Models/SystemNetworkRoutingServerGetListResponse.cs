using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkRoutingServerGetListRequest. The routing Network Server table column
    /// headings are: "Net Address", "Port", "Transport", "Poll", "OpState", "Description".
    /// <see cref="SystemNetworkRoutingServerGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12917""}]")]
    public class SystemNetworkRoutingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _networkRoutingServerTable;

        [XmlElement(ElementName = "networkRoutingServerTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12917")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkRoutingServerTable
        {
            get => _networkRoutingServerTable;
            set
            {
                NetworkRoutingServerTableSpecified = true;
                _networkRoutingServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkRoutingServerTableSpecified { get; set; }

    }
}
