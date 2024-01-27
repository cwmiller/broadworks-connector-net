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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4371""}]")]
    public class ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList22
    {

        protected List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointAdd22> _sharedCallAppearanceAccessDeviceEndpoint = new List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointAdd22>();

        [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4371")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointAdd22> SharedCallAppearanceAccessDeviceEndpoint
        {
            get => _sharedCallAppearanceAccessDeviceEndpoint;
            set
            {
                SharedCallAppearanceAccessDeviceEndpointSpecified = true;
                _sharedCallAppearanceAccessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool SharedCallAppearanceAccessDeviceEndpointSpecified { get; set; }

    }
}
