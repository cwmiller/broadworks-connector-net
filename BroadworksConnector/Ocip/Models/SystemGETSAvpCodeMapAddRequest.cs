using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a GETS AVP Code map at the system level.  It maps a Diameter AVP Code with a vendor ID for.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10897""}]")]
    public class SystemGETSAvpCodeMapAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _avpCode;

        [XmlElement(ElementName = "avpCode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10897")]
        public int AvpCode
        {
            get => _avpCode;
            set
            {
                AvpCodeSpecified = true;
                _avpCode = value;
            }
        }

        [XmlIgnore]
        protected bool AvpCodeSpecified { get; set; }

        protected int _vendorId;

        [XmlElement(ElementName = "vendorId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10897")]
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
