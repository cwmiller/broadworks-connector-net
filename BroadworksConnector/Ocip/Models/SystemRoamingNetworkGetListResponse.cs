using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRoamingNetworkGetListRequest.
    /// Contains a table with columns: "MSC Address", "Network Translation Index".
    /// <see cref="SystemRoamingNetworkGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13895""}]")]
    public class SystemRoamingNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _roamingNetworkTable;

        [XmlElement(ElementName = "roamingNetworkTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13895")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoamingNetworkTable
        {
            get => _roamingNetworkTable;
            set
            {
                RoamingNetworkTableSpecified = true;
                _roamingNetworkTable = value;
            }
        }

        [XmlIgnore]
        public bool RoamingNetworkTableSpecified { get; set; }

    }
}
