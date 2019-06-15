using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderFileRepositoryDeviceUserGetListRequest.
    /// Contains a table with column headings : "User Name","Allow Delete","Allow Get","Allow Put" in a row for each file repository service provider user.
        /// <see cref="ServiceProviderFileRepositoryDeviceUserGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderFileRepositoryDeviceUserGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _fileRepositoryUserTable;

        [XmlElement(ElementName = "fileRepositoryUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FileRepositoryUserTable {
            get => _fileRepositoryUserTable;
            set {
                FileRepositoryUserTableSpecified = true;
                _fileRepositoryUserTable = value;
            }
        }

        [XmlIgnore]
        public bool FileRepositoryUserTableSpecified { get; set; }
        
    }
}
