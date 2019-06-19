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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:879""}]")]
    public class SystemBroadWorksMobilityMobileNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _mobileNetworkTable;

        [XmlElement(ElementName = "mobileNetworkTable", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:879")]
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
        public bool MobileNetworkTableSpecified { get; set; }

    }
}
