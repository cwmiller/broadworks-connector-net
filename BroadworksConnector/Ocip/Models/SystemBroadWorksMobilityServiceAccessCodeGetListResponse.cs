using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksMobilityServiceAccessCodeGetListRequest.
    /// Contains a table with column headings: "Country Code", "Service Access Code", "Description".
    /// Replaced by SystemBroadWorksMobilityServiceAccessCodeGetListReponse21.
        /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityServiceAccessCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceAccessCodeTable;

        [XmlElement(ElementName = "serviceAccessCodeTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceAccessCodeTable {
            get => _serviceAccessCodeTable;
            set {
                ServiceAccessCodeTableSpecified = true;
                _serviceAccessCodeTable = value;
            }
        }

        [XmlIgnore]
        public bool ServiceAccessCodeTableSpecified { get; set; }
        
    }
}
