using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterReportingServerGetListRequest.  The table columns are:
    /// "Name", "URL", "Net Address", and "Description".
    /// <see cref="SystemCallCenterReportingServerGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21759""}]")]
    public class SystemCallCenterReportingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _reportingServerTable;

        [XmlElement(ElementName = "reportingServerTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21759")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ReportingServerTable
        {
            get => _reportingServerTable;
            set
            {
                ReportingServerTableSpecified = true;
                _reportingServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool ReportingServerTableSpecified { get; set; }

    }
}
