using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemXsiPolicyProfileUsageGetListRequest.
    /// Contains a table with column headings: "Organization ID", "Organization Name", "Organization Type" and "Reseller Id".
    /// <see cref="SystemXsiPolicyProfileUsageGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19811""}]")]
    public class SystemXsiPolicyProfileGetAssignedServiceProviderListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _spTable;

        [XmlElement(ElementName = "spTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19811")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SpTable
        {
            get => _spTable;
            set
            {
                SpTableSpecified = true;
                _spTable = value;
            }
        }

        [XmlIgnore]
        protected bool SpTableSpecified { get; set; }

    }
}
