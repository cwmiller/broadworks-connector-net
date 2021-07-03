using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDnGetSummaryListRequest.
    /// The column headings are "Phone Numbers, "Group Id" and "Can Delete"
    /// <see cref="ServiceProviderDnGetSummaryListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3912""}]")]
    public class ServiceProviderDnGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _dnSummaryTable;

        [XmlElement(ElementName = "dnSummaryTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3912")]
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
