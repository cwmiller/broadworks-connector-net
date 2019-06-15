using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest.
    /// Contains a list of number prefixes that are assigned to an enterprise and still available for assignment to users within the enterprise.
    /// The column headings are "Number Prefix" and "Is Active".
        /// <see cref="EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberPrefixTable;

        [XmlElement(ElementName = "availableNumberPrefixTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableNumberPrefixTable {
            get => _availableNumberPrefixTable;
            set {
                AvailableNumberPrefixTableSpecified = true;
                _availableNumberPrefixTable = value;
            }
        }

        [XmlIgnore]
        public bool AvailableNumberPrefixTableSpecified { get; set; }
        
    }
}
