using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCPEConfigGetFileServerListRequest. The table columns are:
    /// "Device Type", "FTP Host Net Address", "FTP User Id", "Directory" and "Passive FTP".
    /// Replaced By: SystemCPEConfigGetFileServerListResponse14sp6
        /// <see cref="SystemCPEConfigGetFileServerListRequest"/>
        /// <see cref="SystemCPEConfigGetFileServerListResponse14sp6"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigGetFileServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
