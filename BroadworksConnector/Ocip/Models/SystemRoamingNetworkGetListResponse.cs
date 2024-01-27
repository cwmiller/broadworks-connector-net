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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15207""}]")]
    public class SystemRoamingNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _roamingNetworkTable;

        [XmlElement(ElementName = "roamingNetworkTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15207")]
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
        protected bool RoamingNetworkTableSpecified { get; set; }

    }
}
