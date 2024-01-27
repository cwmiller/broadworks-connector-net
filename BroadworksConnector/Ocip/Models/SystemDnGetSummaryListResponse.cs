using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDnGetSummaryListRequest.
    /// The column headings are "Phone Numbers, "Service Provider Id", "Is Enterprise" and "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="SystemDnGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9437""}]")]
    public class SystemDnGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _dnSummaryTable;

        [XmlElement(ElementName = "dnSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9437")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnSummaryTable
        {
            get => _dnSummaryTable;
            set
            {
                DnSummaryTableSpecified = true;
                _dnSummaryTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnSummaryTableSpecified { get; set; }

    }
}
