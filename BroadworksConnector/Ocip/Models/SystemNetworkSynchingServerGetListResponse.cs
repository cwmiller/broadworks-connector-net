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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13071""}]")]
    public class SystemNetworkSynchingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _preferredNetworkServerNetAddress;

        [XmlElement(ElementName = "preferredNetworkServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13071")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _networkSynchingServerTable;

        [XmlElement(ElementName = "networkSynchingServerTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13071")]
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
