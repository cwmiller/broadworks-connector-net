using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Call External Emergency Routing system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10260""}]")]
    public class SystemExternalEmergencyRoutingParametersModifyRequest13mp13 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceURI;

        [XmlElement(ElementName = "serviceURI", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10260")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceURI
        {
            get => _serviceURI;
            set
            {
                ServiceURISpecified = true;
                _serviceURI = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceURISpecified { get; set; }

        protected string _defaultEmergencyNumber;

        [XmlElement(ElementName = "defaultEmergencyNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10260")]
        [MinLength(1)]
        [MaxLength(30)]
        public string DefaultEmergencyNumber
        {
            get => _defaultEmergencyNumber;
            set
            {
                DefaultEmergencyNumberSpecified = true;
                _defaultEmergencyNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultEmergencyNumberSpecified { get; set; }

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10260")]
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

        protected bool _supportsDNSSRV;

        [XmlElement(ElementName = "supportsDNSSRV", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10260")]
        public bool SupportsDNSSRV
        {
            get => _supportsDNSSRV;
            set
            {
                SupportsDNSSRVSpecified = true;
                _supportsDNSSRV = value;
            }
        }

        [XmlIgnore]
        protected bool SupportsDNSSRVSpecified { get; set; }

        protected int _connectionTimeoutSeconds;

        [XmlElement(ElementName = "connectionTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10260")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int ConnectionTimeoutSeconds
        {
            get => _connectionTimeoutSeconds;
            set
            {
                ConnectionTimeoutSecondsSpecified = true;
                _connectionTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ConnectionTimeoutSecondsSpecified { get; set; }

    }
}
