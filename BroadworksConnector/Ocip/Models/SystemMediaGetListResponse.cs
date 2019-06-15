using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaGetListRequest. The column headings are
    /// "Media Name", "Codec", "Media Type", "Bandwidth Enforcement Type" and "Bandwidth".
        /// <see cref="SystemMediaGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _mediaTable;

        [XmlElement(ElementName = "mediaTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MediaTable {
            get => _mediaTable;
            set {
                MediaTableSpecified = true;
                _mediaTable = value;
            }
        }

        [XmlIgnore]
        public bool MediaTableSpecified { get; set; }
        
    }
}
