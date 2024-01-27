using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all system-level call recording platforms and all reseller level call recording platforms.
    /// If an excludeReseller is specified, returns all the system-level call recording platforms only.
    /// If a resellerId is specified, returns all the system-level call recording platforms and the given reseller's call recording platforms.
    /// If a reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
    /// The response is either SystemCallRecordingGetPlatformListResponse22V2 or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// excludeReseller
    /// resellerId
    /// <see cref="SystemCallRecordingGetPlatformListResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""0731150ec7515df8cd710f04d8f62f66:261""}]")]
    public class SystemCallRecordingGetPlatformListRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallRecordingGetPlatformListResponse22V2>
    {

        protected bool _excludeReseller;

        [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:261")]
        public bool ExcludeReseller
        {
            get => _excludeReseller;
            set
            {
                ExcludeResellerSpecified = true;
                _excludeReseller = value;
            }
        }

        [XmlIgnore]
        protected bool ExcludeResellerSpecified { get; set; }

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:261")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

    }
}
