using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a ServiceProviderPreferredCarrierGetListRequest. Contains a table with one row per carrier.
    /// The table columns are: "Country Code", "Intra-Lata PIC", "Inter-Lata PIC", "International PIC".
        /// <see cref="ServiceProviderPreferredCarrierGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderPreferredCarrierGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderCarrierTable;

        [XmlElement(ElementName = "serviceProviderCarrierTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderCarrierTable {
            get => _serviceProviderCarrierTable;
            set {
                ServiceProviderCarrierTableSpecified = true;
                _serviceProviderCarrierTable = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderCarrierTableSpecified { get; set; }
        
    }
}
