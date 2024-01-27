using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Switch the device type for all devices at the specified scope for a device type.
    /// To switch all the device type's device profiles for the system, neither the serviceProviderId and groupId should be present.
    /// To switch all the device type's device profiles for a service provider, only serviceProviderId should be specified.
    /// To switch all the device type's device profiles for a group, serviceProviderId and groupId should specified.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8044"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8045"",""optional"":true,""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8047""}]}]}]")]
    public class SystemDeviceManagementSwitchDeviceTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8045")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _svcProviderId;

        [XmlElement(ElementName = "svcProviderId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8047")]
        [MinLength(1)]
        [MaxLength(30)]
        public string SvcProviderId
        {
            get => _svcProviderId;
            set
            {
                SvcProviderIdSpecified = true;
                _svcProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool SvcProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8047")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected string _fromDeviceType;

        [XmlElement(ElementName = "fromDeviceType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8044")]
        [MinLength(1)]
        [MaxLength(40)]
        public string FromDeviceType
        {
            get => _fromDeviceType;
            set
            {
                FromDeviceTypeSpecified = true;
                _fromDeviceType = value;
            }
        }

        [XmlIgnore]
        protected bool FromDeviceTypeSpecified { get; set; }

        protected string _toDeviceType;

        [XmlElement(ElementName = "toDeviceType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8044")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ToDeviceType
        {
            get => _toDeviceType;
            set
            {
                ToDeviceTypeSpecified = true;
                _toDeviceType = value;
            }
        }

        [XmlIgnore]
        protected bool ToDeviceTypeSpecified { get; set; }

    }
}
