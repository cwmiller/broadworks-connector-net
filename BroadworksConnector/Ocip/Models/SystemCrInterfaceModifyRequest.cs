using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Cr Interface.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7384""}]")]
    public class SystemCrInterfaceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _crAuditEnabled;

        [XmlElement(ElementName = "crAuditEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7384")]
        public bool CrAuditEnabled
        {
            get => _crAuditEnabled;
            set
            {
                CrAuditEnabledSpecified = true;
                _crAuditEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool CrAuditEnabledSpecified { get; set; }

        protected int _crAuditIntervalMilliseconds;

        [XmlElement(ElementName = "crAuditIntervalMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7384")]
        [MinInclusive(500)]
        [MaxInclusive(60000)]
        public int CrAuditIntervalMilliseconds
        {
            get => _crAuditIntervalMilliseconds;
            set
            {
                CrAuditIntervalMillisecondsSpecified = true;
                _crAuditIntervalMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool CrAuditIntervalMillisecondsSpecified { get; set; }

        protected int _crAuditTimeoutMilliseconds;

        [XmlElement(ElementName = "crAuditTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7384")]
        [MinInclusive(500)]
        [MaxInclusive(10000)]
        public int CrAuditTimeoutMilliseconds
        {
            get => _crAuditTimeoutMilliseconds;
            set
            {
                CrAuditTimeoutMillisecondsSpecified = true;
                _crAuditTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool CrAuditTimeoutMillisecondsSpecified { get; set; }

        protected bool _crConnectionEnabled;

        [XmlElement(ElementName = "crConnectionEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7384")]
        public bool CrConnectionEnabled
        {
            get => _crConnectionEnabled;
            set
            {
                CrConnectionEnabledSpecified = true;
                _crConnectionEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool CrConnectionEnabledSpecified { get; set; }

        protected int _crConnectionTimeoutMilliseconds;

        [XmlElement(ElementName = "crConnectionTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7384")]
        [MinInclusive(1000)]
        [MaxInclusive(32000)]
        public int CrConnectionTimeoutMilliseconds
        {
            get => _crConnectionTimeoutMilliseconds;
            set
            {
                CrConnectionTimeoutMillisecondsSpecified = true;
                _crConnectionTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool CrConnectionTimeoutMillisecondsSpecified { get; set; }

        protected int _crTcpConnectionTimeoutSeconds;

        [XmlElement(ElementName = "crTcpConnectionTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7384")]
        [MinInclusive(1)]
        [MaxInclusive(120)]
        public int CrTcpConnectionTimeoutSeconds
        {
            get => _crTcpConnectionTimeoutSeconds;
            set
            {
                CrTcpConnectionTimeoutSecondsSpecified = true;
                _crTcpConnectionTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool CrTcpConnectionTimeoutSecondsSpecified { get; set; }

        protected int _crNumberOfReconnectionAttempts;

        [XmlElement(ElementName = "crNumberOfReconnectionAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7384")]
        [MinInclusive(0)]
        [MaxInclusive(100)]
        public int CrNumberOfReconnectionAttempts
        {
            get => _crNumberOfReconnectionAttempts;
            set
            {
                CrNumberOfReconnectionAttemptsSpecified = true;
                _crNumberOfReconnectionAttempts = value;
            }
        }

        [XmlIgnore]
        protected bool CrNumberOfReconnectionAttemptsSpecified { get; set; }

    }
}
