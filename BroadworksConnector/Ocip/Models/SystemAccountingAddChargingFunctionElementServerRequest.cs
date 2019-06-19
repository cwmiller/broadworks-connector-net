using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a ChargingFunctionElement Server to the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1376""}]")]
    public class SystemAccountingAddChargingFunctionElementServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1376")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Address
        {
            get => _address;
            set
            {
                AddressSpecified = true;
                _address = value;
            }
        }

        [XmlIgnore]
        public bool AddressSpecified { get; set; }

        private bool _isNetAddressExtended;

        [XmlElement(ElementName = "isNetAddressExtended", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1376")]
        public bool IsNetAddressExtended
        {
            get => _isNetAddressExtended;
            set
            {
                IsNetAddressExtendedSpecified = true;
                _isNetAddressExtended = value;
            }
        }

        [XmlIgnore]
        public bool IsNetAddressExtendedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ChargingFunctionElementServerType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1376")]
        public BroadWorksConnector.Ocip.Models.ChargingFunctionElementServerType Type
        {
            get => _type;
            set
            {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1376")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }

    }
}
