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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8244""}]")]
    public class SystemDnGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _dnSummaryTable;

        [XmlElement(ElementName = "dnSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8244")]
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
        public bool DnSummaryTableSpecified { get; set; }

    }
}
