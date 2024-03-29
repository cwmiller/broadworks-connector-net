using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify SMDI system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17961""}]")]
    public class SystemSMDIParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enableSMDI;

        [XmlElement(ElementName = "enableSMDI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17961")]
        public bool EnableSMDI
        {
            get => _enableSMDI;
            set
            {
                EnableSMDISpecified = true;
                _enableSMDI = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSMDISpecified { get; set; }

        protected int _listeningPort;

        [XmlElement(ElementName = "listeningPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17961")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int ListeningPort
        {
            get => _listeningPort;
            set
            {
                ListeningPortSpecified = true;
                _listeningPort = value;
            }
        }

        [XmlIgnore]
        protected bool ListeningPortSpecified { get; set; }

        protected int _maxConnections;

        [XmlElement(ElementName = "maxConnections", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17961")]
        [MinInclusive(0)]
        [MaxInclusive(64)]
        public int MaxConnections
        {
            get => _maxConnections;
            set
            {
                MaxConnectionsSpecified = true;
                _maxConnections = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConnectionsSpecified { get; set; }

    }
}
