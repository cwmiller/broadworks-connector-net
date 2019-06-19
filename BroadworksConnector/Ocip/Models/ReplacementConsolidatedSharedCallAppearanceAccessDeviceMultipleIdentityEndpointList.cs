using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of shared call appearance endpoints that replaces existing endpoints.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3256""}]")]
    public class ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList
    {

        private List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> _sharedCallAppearanceAccessDeviceEndpoint = new List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint>();

        [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3256")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> SharedCallAppearanceAccessDeviceEndpoint
        {
            get => _sharedCallAppearanceAccessDeviceEndpoint;
            set
            {
                SharedCallAppearanceAccessDeviceEndpointSpecified = true;
                _sharedCallAppearanceAccessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool SharedCallAppearanceAccessDeviceEndpointSpecified { get; set; }

    }
}
