using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an Attribute Value Pair (AVP) combination to disable. The AVP
    /// combination includes a diameter AVP and a vendor ID. The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccountingInhibitedAttributeValuePairCodeAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _attributeValuePairCode;

        [XmlElement(ElementName = "attributeValuePairCode", IsNullable = false, Namespace = "")]
        public int AttributeValuePairCode {
            get => _attributeValuePairCode;
            set {
                AttributeValuePairCodeSpecified = true;
                _attributeValuePairCode = value;
            }
        }

        [XmlIgnore]
        public bool AttributeValuePairCodeSpecified { get; set; }
        
        private int _vendorId;

        [XmlElement(ElementName = "vendorId", IsNullable = false, Namespace = "")]
        public int VendorId {
            get => _vendorId;
            set {
                VendorIdSpecified = true;
                _vendorId = value;
            }
        }

        [XmlIgnore]
        public bool VendorIdSpecified { get; set; }
        
    }
}
