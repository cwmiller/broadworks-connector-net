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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13234""}]")]
    public class SystemPerformanceMeasurementReportingGetFileServerListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _fileServerTable;

        [XmlElement(ElementName = "fileServerTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13234")]
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
        public bool FileServerTableSpecified { get; set; }

    }
}
