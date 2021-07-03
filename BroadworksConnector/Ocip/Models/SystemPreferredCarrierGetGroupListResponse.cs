using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemPreferredCarrierGetGroupListRequest.
    /// Contains a table with one row per group.
    /// The table columns are: "Group Id", "Group Name", "Organization Id", "Organization Type".
    /// The "Organization Id" column is populated with either a service provider Id or an enterprise Id.
    /// The "Organization Type" column is populated with one of the enumerated strings defined in the
    /// OrganizationType OCI data type.  Please see OCISchemaDataTypes.xsd for details on OrganizationType.
    /// <see cref="SystemPreferredCarrierGetGroupListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:385""}]")]
    public class SystemPreferredCarrierGetGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _groupsUsingCarrierTable;

        [XmlElement(ElementName = "groupsUsingCarrierTable", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:385")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupsUsingCarrierTable
        {
            get => _groupsUsingCarrierTable;
            set
            {
                GroupsUsingCarrierTableSpecified = true;
                _groupsUsingCarrierTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupsUsingCarrierTableSpecified { get; set; }

    }
}
