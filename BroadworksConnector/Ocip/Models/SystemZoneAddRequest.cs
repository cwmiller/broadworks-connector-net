using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Zone and optional Net Addresses and Physical Locations.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19594""}]")]
    public class SystemZoneAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19594")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ZoneName
        {
            get => _zoneName;
            set
            {
                ZoneNameSpecified = true;
                _zoneName = value;
            }
        }

        [XmlIgnore]
        protected bool ZoneNameSpecified { get; set; }

        protected List<string> _netAddress = new List<string>();

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19594")]
        [MinLength(1)]
        [MaxLength(39)]
        public List<string> NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NetAddressSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.IPAddressRange> _netAddressRange = new List<BroadWorksConnector.Ocip.Models.IPAddressRange>();

        [XmlElement(ElementName = "netAddressRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19594")]
        public List<BroadWorksConnector.Ocip.Models.IPAddressRange> NetAddressRange
        {
            get => _netAddressRange;
            set
            {
                NetAddressRangeSpecified = true;
                _netAddressRange = value;
            }
        }

        [XmlIgnore]
        protected bool NetAddressRangeSpecified { get; set; }

        protected List<string> _locationBasedPhysicalLocation = new List<string>();

        [XmlElement(ElementName = "locationBasedPhysicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19594")]
        [MinLength(1)]
        [MaxLength(1024)]
        public List<string> LocationBasedPhysicalLocation
        {
            get => _locationBasedPhysicalLocation;
            set
            {
                LocationBasedPhysicalLocationSpecified = true;
                _locationBasedPhysicalLocation = value;
            }
        }

        [XmlIgnore]
        protected bool LocationBasedPhysicalLocationSpecified { get; set; }

        protected string _callingZonePhysicalLocation;

        [XmlElement(ElementName = "callingZonePhysicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19594")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string CallingZonePhysicalLocation
        {
            get => _callingZonePhysicalLocation;
            set
            {
                CallingZonePhysicalLocationSpecified = true;
                _callingZonePhysicalLocation = value;
            }
        }

        [XmlIgnore]
        protected bool CallingZonePhysicalLocationSpecified { get; set; }

    }
}
