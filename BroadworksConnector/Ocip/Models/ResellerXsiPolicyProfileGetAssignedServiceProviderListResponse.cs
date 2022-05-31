using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerXsiPolicyProfileGetAssignedServiceProviderListRequest.
    /// Contains a table of Service Providers that have the Xsi Policy Profile
    /// assigned. The column headings are: "Organization ID", "Organization Name", "Organization Type".
    /// <see cref="ResellerXsiPolicyProfileGetAssignedServiceProviderListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:1025""}]")]
    public class ResellerXsiPolicyProfileGetAssignedServiceProviderListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _svcProviderTable;

        [XmlElement(ElementName = "svcProviderTable", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:1025")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SvcProviderTable
        {
            get => _svcProviderTable;
            set
            {
                SvcProviderTableSpecified = true;
                _svcProviderTable = value;
            }
        }

        [XmlIgnore]
        protected bool SvcProviderTableSpecified { get; set; }

    }
}
