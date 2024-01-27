using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDnUtilizationGetListRequest.
    /// The table columns are: "Service Provider Id", "Phone Numbers", "Assigned to Groups",
    /// "Percentage Assigned", "Is Enterprise", "Activated on Groups", "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="SystemDnUtilizationGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9479""}]")]
    public class SystemDnGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _dnUtilizationTable;

        [XmlElement(ElementName = "dnUtilizationTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9479")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnUtilizationTable
        {
            get => _dnUtilizationTable;
            set
            {
                DnUtilizationTableSpecified = true;
                _dnUtilizationTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnUtilizationTableSpecified { get; set; }

    }
}
