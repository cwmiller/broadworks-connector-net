using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseLocalGatewayGetUsageRequest.
    /// Returns the group ID and group name where the local gateway belongs to, a boolean value to indicate if the local gateway is
    /// used in the enterprise call processing policy.
    /// It also returns an OCITable containing the groups using the given local gateway.
    /// Column headings are: "Group Id", "Group Name" and "Group External Id".
    /// The following columns are only populated in AS data mode
    /// "Group External Id"
    /// <see cref="EnterpriseLocalGatewayGetUsageRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:546""}]")]
    public class EnterpriseLocalGatewayGetUsageResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _gatewayGroupId;

        [XmlElement(ElementName = "gatewayGroupId", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:546")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GatewayGroupId
        {
            get => _gatewayGroupId;
            set
            {
                GatewayGroupIdSpecified = true;
                _gatewayGroupId = value;
            }
        }

        [XmlIgnore]
        protected bool GatewayGroupIdSpecified { get; set; }

        private string _gatewayGroupName;

        [XmlElement(ElementName = "gatewayGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:546")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GatewayGroupName
        {
            get => _gatewayGroupName;
            set
            {
                GatewayGroupNameSpecified = true;
                _gatewayGroupName = value;
            }
        }

        [XmlIgnore]
        protected bool GatewayGroupNameSpecified { get; set; }

        private bool _usedByEnterprise;

        [XmlElement(ElementName = "usedByEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:546")]
        public bool UsedByEnterprise
        {
            get => _usedByEnterprise;
            set
            {
                UsedByEnterpriseSpecified = true;
                _usedByEnterprise = value;
            }
        }

        [XmlIgnore]
        protected bool UsedByEnterpriseSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:546")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupTable
        {
            get => _groupTable;
            set
            {
                GroupTableSpecified = true;
                _groupTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupTableSpecified { get; set; }

    }
}
