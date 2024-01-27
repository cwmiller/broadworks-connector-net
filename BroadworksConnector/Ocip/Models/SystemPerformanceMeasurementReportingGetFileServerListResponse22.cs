using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPerformanceMeasurementReportingGetFileServerListRequest22. The table columns are:
    /// "Repository URL", "User Id", "Passive".
    /// <see cref="SystemPerformanceMeasurementReportingGetFileServerListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14521""}]")]
    public class SystemPerformanceMeasurementReportingGetFileServerListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _fileServerTable;

        [XmlElement(ElementName = "fileServerTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14521")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FileServerTable
        {
            get => _fileServerTable;
            set
            {
                FileServerTableSpecified = true;
                _fileServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool FileServerTableSpecified { get; set; }

    }
}
