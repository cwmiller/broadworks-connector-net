using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemFileRepositoryDeviceGetListRequest.
    /// Contains a table with column headings : "Name","Protocol", "Root Directory", "Extended File Capture Support" in a row for each file repository.
        /// <see cref="SystemFileRepositoryDeviceGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileRepositoryDeviceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _fileRepositoryTable;

        [XmlElement(ElementName = "fileRepositoryTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FileRepositoryTable {
            get => _fileRepositoryTable;
            set {
                FileRepositoryTableSpecified = true;
                _fileRepositoryTable = value;
            }
        }

        [XmlIgnore]
        public bool FileRepositoryTableSpecified { get; set; }
        
    }
}
