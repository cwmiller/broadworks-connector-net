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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:545""}]")]
    public class EnterpriseLocalGatewayGetUsageResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _gatewayGroupId;

        [XmlElement(ElementName = "gatewayGroupId", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:545")]
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

        protected string _gatewayGroupName;

        [XmlElement(ElementName = "gatewayGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:545")]
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

        protected bool _usedByEnterprise;

        [XmlElement(ElementName = "usedByEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:545")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:545")]
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
