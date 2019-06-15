using System;
using System.Xml.Serialization;
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
     
    public class SystemPerformanceMeasurementReportingGetFileServerListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _fileServerTable;

        [XmlElement(ElementName = "fileServerTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FileServerTable {
            get => _fileServerTable;
            set {
                FileServerTableSpecified = true;
                _fileServerTable = value;
            }
        }

        [XmlIgnore]
        public bool FileServerTableSpecified { get; set; }
        
    }
}
