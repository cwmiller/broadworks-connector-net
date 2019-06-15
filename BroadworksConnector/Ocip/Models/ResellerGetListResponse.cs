using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerGetListRequest.
    /// Contains a 2 column table with column headings "Reseller Id", "Reseller Name". A row for each reseller.
        /// <see cref="ResellerGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ResellerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _resellerTable;

        [XmlElement(ElementName = "resellerTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ResellerTable {
            get => _resellerTable;
            set {
                ResellerTableSpecified = true;
                _resellerTable = value;
            }
        }

        [XmlIgnore]
        public bool ResellerTableSpecified { get; set; }
        
    }
}
