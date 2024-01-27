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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:507""}]")]
    public class EnterpriseLocalGatewayGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _localGatewayTable;

        [XmlElement(ElementName = "localGatewayTable", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:507")]
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
