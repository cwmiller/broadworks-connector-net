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
    /// The response is either SystemCallRecordingGetPlatformListResponse22 or ErrorResponse.
    /// 
    /// Replaced by: SystemCallRecordingGetPlatformListRequest22V2
    /// <see cref="SystemCallRecordingGetPlatformListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallRecordingGetPlatformListRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9115""}]")]
    public class SystemCallRecordingGetPlatformListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallRecordingGetPlatformListResponse22>
    {

        protected bool _excludeReseller;

        [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9115")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:9115")]
        [MinLength(1)]
        [MaxLength(30)]
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
