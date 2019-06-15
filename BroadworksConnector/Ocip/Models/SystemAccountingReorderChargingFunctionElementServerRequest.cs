using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Reorder the charging function element servers. You can not add or delete addresses,
    /// only re-ordering the list is allowed. The ordered list of addresses can be obtained
    /// with the SystemAccountingGetChargingFunctionElementServerListRequest command.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SystemAccountingGetChargingFunctionElementServerListRequest"/>
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccountingReorderChargingFunctionElementServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<string> _orderedAddressList;

        [XmlElement(ElementName = "orderedAddressList", IsNullable = false, Namespace = "")]
        public List<string> OrderedAddressList {
            get => _orderedAddressList;
            set {
                OrderedAddressListSpecified = true;
                _orderedAddressList = value;
            }
        }

        [XmlIgnore]
        public bool OrderedAddressListSpecified { get; set; }
        
    }
}
