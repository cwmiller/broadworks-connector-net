using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkSynchingServerGetListRequest. The Network Server table column
    /// headings are: "Net Address", "Port", "Secure", "Description", "Order".
    /// The following columns are only used in XS data mode and not returned in AS data mode:
    /// Order
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// preferredNetworkServerNetAddress
    /// <see cref="SystemNetworkSynchingServerGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12901""}]")]
    public class SystemNetworkSynchingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _preferredNetworkServerNetAddress;

        [XmlElement(ElementName = "preferredNetworkServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12901")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PreferredNetworkServerNetAddress
        {
            get => _preferredNetworkServerNetAddress;
            set
            {
                PreferredNetworkServerNetAddressSpecified = true;
                _preferredNetworkServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool PreferredNetworkServerNetAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _networkSynchingServerTable;

        [XmlElement(ElementName = "networkSynchingServerTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12901")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkSynchingServerTable
        {
            get => _networkSynchingServerTable;
            set
            {
                NetworkSynchingServerTableSpecified = true;
                _networkSynchingServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkSynchingServerTableSpecified { get; set; }

    }
}
