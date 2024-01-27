using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response to a SystemBroadWorksMobilityMobileNetworkGetListRequest.
    /// Contains a table with column headings: "Name", "SCF Signaling Net Address", "SCF Signaling Port"
    /// <see cref="SystemBroadWorksMobilityMobileNetworkGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1123""}]")]
    public class SystemBroadWorksMobilityMobileNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _mobileNetworkTable;

        [XmlElement(ElementName = "mobileNetworkTable", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1123")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileNetworkTable
        {
            get => _mobileNetworkTable;
            set
            {
                MobileNetworkTableSpecified = true;
                _mobileNetworkTable = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNetworkTableSpecified { get; set; }

    }
}
