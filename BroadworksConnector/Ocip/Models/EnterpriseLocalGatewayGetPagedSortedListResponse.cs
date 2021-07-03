using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseLocalGatewayGetPagedSortedListRequest.
    /// Contains a table with column headings "Name", "Device Name", "Device Level", "Group Id", "Group Name"  and "Group External Id".
    /// The "Device Level" column contains one of the AccessDeviceLevel enumerated constants.
    /// The following columns are only populated in AS data mode
    /// "Group External Id"
    /// <see cref="EnterpriseLocalGatewayGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:508""}]")]
    public class EnterpriseLocalGatewayGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _localGatewayTable;

        [XmlElement(ElementName = "localGatewayTable", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:508")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LocalGatewayTable
        {
            get => _localGatewayTable;
            set
            {
                LocalGatewayTableSpecified = true;
                _localGatewayTable = value;
            }
        }

        [XmlIgnore]
        protected bool LocalGatewayTableSpecified { get; set; }

    }
}
