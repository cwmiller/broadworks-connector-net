using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an Attribute Value Pair (AVP) combination to disable. The AVP
    /// combination includes a diameter AVP and a vendor ID.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1991""}]")]
    public class SystemAccountingInhibitedAttributeValuePairCodeAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _attributeValuePairCode;

        [XmlElement(ElementName = "attributeValuePairCode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1991")]
        public int AttributeValuePairCode
        {
            get => _attributeValuePairCode;
            set
            {
                AttributeValuePairCodeSpecified = true;
                _attributeValuePairCode = value;
            }
        }

        [XmlIgnore]
        protected bool AttributeValuePairCodeSpecified { get; set; }

        protected int _vendorId;

        [XmlElement(ElementName = "vendorId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1991")]
        public int VendorId
        {
            get => _vendorId;
            set
            {
                VendorIdSpecified = true;
                _vendorId = value;
            }
        }

        [XmlIgnore]
        protected bool VendorIdSpecified { get; set; }

    }
}
