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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12747""}]")]
    public class SystemNetworkRoutingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _networkRoutingServerTable;

        [XmlElement(ElementName = "networkRoutingServerTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12747")]
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
