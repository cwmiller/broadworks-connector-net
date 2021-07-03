using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a system GETS AVP Code map.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10790""}]")]
    public class SystemGETSAvpCodeMapDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _avpCode;

        [XmlElement(ElementName = "avpCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10790")]
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

        private int _vendorId;

        [XmlElement(ElementName = "vendorId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10790")]
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
