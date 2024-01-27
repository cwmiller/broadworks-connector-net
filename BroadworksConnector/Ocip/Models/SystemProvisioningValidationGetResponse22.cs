using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemProvisioningValidationGetRequest22.
    /// Replaced by SystemProvisioningValidationGetResponse25.
    /// <see cref="SystemProvisioningValidationGetRequest22"/>
    /// <see cref="SystemProvisioningValidationGetResponse25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:11501""}]")]
    public class SystemProvisioningValidationGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11501")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected bool _isNetworkServerQueryActive;

        [XmlElement(ElementName = "isNetworkServerQueryActive", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11501")]
        public bool IsNetworkServerQueryActive
        {
            get => _isNetworkServerQueryActive;
            set
            {
                IsNetworkServerQueryActiveSpecified = true;
                _isNetworkServerQueryActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsNetworkServerQueryActiveSpecified { get; set; }

        protected int _timeoutSeconds;

        [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11501")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int TimeoutSeconds
        {
            get => _timeoutSeconds;
            set
            {
                TimeoutSecondsSpecified = true;
                _timeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeoutSecondsSpecified { get; set; }

        protected bool _denyMobilityNumberAsRedirectionDestination;

        [XmlElement(ElementName = "denyMobilityNumberAsRedirectionDestination", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11501")]
        public bool DenyMobilityNumberAsRedirectionDestination
        {
            get => _denyMobilityNumberAsRedirectionDestination;
            set
            {
                DenyMobilityNumberAsRedirectionDestinationSpecified = true;
                _denyMobilityNumberAsRedirectionDestination = value;
            }
        }

        [XmlIgnore]
        protected bool DenyMobilityNumberAsRedirectionDestinationSpecified { get; set; }

        protected bool _denyEnterpriseNumberAsNetworkLocationDestination;

        [XmlElement(ElementName = "denyEnterpriseNumberAsNetworkLocationDestination", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11501")]
        public bool DenyEnterpriseNumberAsNetworkLocationDestination
        {
            get => _denyEnterpriseNumberAsNetworkLocationDestination;
            set
            {
                DenyEnterpriseNumberAsNetworkLocationDestinationSpecified = true;
                _denyEnterpriseNumberAsNetworkLocationDestination = value;
            }
        }

        [XmlIgnore]
        protected bool DenyEnterpriseNumberAsNetworkLocationDestinationSpecified { get; set; }

    }
}
