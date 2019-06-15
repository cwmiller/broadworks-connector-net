using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCrInterfaceGetRequest22.
        /// <see cref="SystemCrInterfaceGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCrInterfaceGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _crAuditEnabled;

        [XmlElement(ElementName = "crAuditEnabled", IsNullable = false, Namespace = "")]
        public bool CrAuditEnabled {
            get => _crAuditEnabled;
            set {
                CrAuditEnabledSpecified = true;
                _crAuditEnabled = value;
            }
        }

        [XmlIgnore]
        public bool CrAuditEnabledSpecified { get; set; }
        
        private int _crAuditIntervalMilliseconds;

        [XmlElement(ElementName = "crAuditIntervalMilliseconds", IsNullable = false, Namespace = "")]
        public int CrAuditIntervalMilliseconds {
            get => _crAuditIntervalMilliseconds;
            set {
                CrAuditIntervalMillisecondsSpecified = true;
                _crAuditIntervalMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool CrAuditIntervalMillisecondsSpecified { get; set; }
        
        private int _crAuditTimeoutMilliseconds;

        [XmlElement(ElementName = "crAuditTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        public int CrAuditTimeoutMilliseconds {
            get => _crAuditTimeoutMilliseconds;
            set {
                CrAuditTimeoutMillisecondsSpecified = true;
                _crAuditTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool CrAuditTimeoutMillisecondsSpecified { get; set; }
        
        private bool _crConnectionEnabled;

        [XmlElement(ElementName = "crConnectionEnabled", IsNullable = false, Namespace = "")]
        public bool CrConnectionEnabled {
            get => _crConnectionEnabled;
            set {
                CrConnectionEnabledSpecified = true;
                _crConnectionEnabled = value;
            }
        }

        [XmlIgnore]
        public bool CrConnectionEnabledSpecified { get; set; }
        
        private int _crConnectionTimeoutMilliseconds;

        [XmlElement(ElementName = "crConnectionTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        public int CrConnectionTimeoutMilliseconds {
            get => _crConnectionTimeoutMilliseconds;
            set {
                CrConnectionTimeoutMillisecondsSpecified = true;
                _crConnectionTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool CrConnectionTimeoutMillisecondsSpecified { get; set; }
        
        private int _crTcpConnectionTimeoutSeconds;

        [XmlElement(ElementName = "crTcpConnectionTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int CrTcpConnectionTimeoutSeconds {
            get => _crTcpConnectionTimeoutSeconds;
            set {
                CrTcpConnectionTimeoutSecondsSpecified = true;
                _crTcpConnectionTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool CrTcpConnectionTimeoutSecondsSpecified { get; set; }
        
        private int _crNumberOfReconnectionAttempts;

        [XmlElement(ElementName = "crNumberOfReconnectionAttempts", IsNullable = false, Namespace = "")]
        public int CrNumberOfReconnectionAttempts {
            get => _crNumberOfReconnectionAttempts;
            set {
                CrNumberOfReconnectionAttemptsSpecified = true;
                _crNumberOfReconnectionAttempts = value;
            }
        }

        [XmlIgnore]
        public bool CrNumberOfReconnectionAttemptsSpecified { get; set; }
        
    }
}
